using Abp.Domain.Repositories;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Services
{
    public class AttendanceRecordDomainService : IAttendanceRecordDomainService
    {
        private readonly IRepository<AttendanceRecord,Guid>  _attendanceRecordRepository;
        private readonly IRepository<AttendanceMonthlyCard,Guid>  _attendanceMonthlyCardRepository;
        private readonly IRepository<EmployeeCard,Guid>  _employeeCardRepository;
        private readonly IRepository<Employee,Guid>  _employeeRepository;
        private readonly ICompanyHolidayDomainService _companyHolidayDomainService;
        private readonly IFixedHolidayDomainService _fixedHolidayDomainService;
        private readonly IChangeableHolidayDomainService _changeableHolidayDomainService;
        private readonly IRepository<LeaveRequest, Guid> _leaveRequestRepository;
        private readonly IRepository<EntranceExitRecord, Guid> _entranceExitRecordRepository;
        private readonly IRepository<AttendanceForm,Guid> _attendanceFormRepository;
        private readonly IRepository<Workshop,Guid> _workshopRepository;
        private readonly IRepository<NormalShift,Guid> _normalShiftRepository;
        private readonly IRepository<FinancialCard,Guid> _financialCardRepository;

        public AttendanceRecordDomainService(IRepository<AttendanceRecord, Guid> attendanceRecordRepository, IRepository<EmployeeCard, Guid> employeeCardRepository, IRepository<Employee, Guid> employeeRepository, IRepository<AttendanceMonthlyCard, Guid> attendanceMonthlyCardRepository, ICompanyHolidayDomainService companyHolidayDomainService, IFixedHolidayDomainService fixedHolidayDomainService, IChangeableHolidayDomainService changeableHolidayDomainService, IRepository<LeaveRequest, Guid> leaveRequestRepository, IRepository<EntranceExitRecord, Guid> entranceExitRecordRepository, IRepository<AttendanceForm, Guid> attendanceFormRepository, IRepository<Workshop, Guid> workshopRepository, IRepository<NormalShift, Guid> normalShiftRepository, IRepository<FinancialCard, Guid> financialCardRepository)
        {
            _attendanceRecordRepository = attendanceRecordRepository;
            _employeeCardRepository = employeeCardRepository;
            _employeeRepository = employeeRepository;
            _attendanceMonthlyCardRepository = attendanceMonthlyCardRepository;
            _companyHolidayDomainService = companyHolidayDomainService;
            _fixedHolidayDomainService = fixedHolidayDomainService;
            _changeableHolidayDomainService = changeableHolidayDomainService;
            _leaveRequestRepository = leaveRequestRepository;
            _entranceExitRecordRepository = entranceExitRecordRepository;
            _attendanceFormRepository = attendanceFormRepository;
            _workshopRepository = workshopRepository;
            _normalShiftRepository = normalShiftRepository;
            _financialCardRepository = financialCardRepository;
        }

        public async Task CalculateMonth(Guid id)
        {
            var record = await _attendanceRecordRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (record != null)
            {
                await _attendanceRecordRepository.EnsureCollectionLoadedAsync(record, x => x.AttendanceMonthlyCards);
                if (record.AttendanceMonthlyCards == null)
                {
                    record.AttendanceMonthlyCards = new List<AttendanceMonthlyCard>();
                }
                for(DateTime dt = record.FromDate;dt < record.ToDate;dt = dt.AddDays(1))
                {
                    // Check if this date is holiday
                    // company holiday by default (friday - saturday)
                   
                    // if holiday skip
                    // if not holiday continue the process
                    foreach(var employeeCard in record.AttendanceMonthlyCards)
                    {
                        await _attendanceMonthlyCardRepository.EnsurePropertyLoadedAsync(employeeCard, x => x.EmployeeCard);
                        await _employeeCardRepository.EnsurePropertyLoadedAsync(employeeCard.EmployeeCard, x => x.Employee);
                        var employee = employeeCard.EmployeeCard.Employee;

                        if (employee != null)
                        {
                            double requiredHours = 0;
                            double actualHours = 0;
                            bool holidayConfirmed = false;

                            var companyHolidays = await _companyHolidayDomainService.GetAll();
                            if (!holidayConfirmed && companyHolidays.Any(x => x.DayOfWeek.ToString() == dt.Day.ToString()))
                            {
                                requiredHours += 8;
                                actualHours += 8;
                                holidayConfirmed = true;
                            }
                            var fixedHolidays = await _fixedHolidayDomainService.GetAll();
                            if(!holidayConfirmed && fixedHolidays.Any(x => x.Month.ToString() == dt.Month.ToString() && x.Day.ToString() == dt.Day.ToString()))
                            {
                                requiredHours += 8;
                                actualHours += 8;
                                holidayConfirmed = true;
                            }
                            var changeableHolidays = await _changeableHolidayDomainService.GetAll();
                            if (!holidayConfirmed && changeableHolidays.Any(x => x.StartDate <= dt && x.EndDate >= dt))
                            {
                                requiredHours += 8;
                                actualHours += 8;
                                holidayConfirmed = true;
                            }

                            if (holidayConfirmed)
                            {
                                employeeCard.TotalRequiredWorkHours = requiredHours;
                                employeeCard.ActualTotalWorkHours = actualHours;
                                employeeCard.isCalculated = true;
                                continue;
                            }

                            requiredHours += 8;
                            bool leaveConfirmed = false;

                            var leaveRequests = _leaveRequestRepository.GetAll().Where(x => x.EmployeeId == employee.Id && x.StartDate <=  dt && x.EndDate > dt).ToList();
                            foreach(var leaveRequest in leaveRequests)
                            {
                                await _leaveRequestRepository.EnsurePropertyLoadedAsync(leaveRequest, x => x.LeaveSetting);
                                if(leaveRequest.LeaveSetting.isPaidLeave)
                                {
                                    requiredHours += 8;
                                    actualHours += 8;
                                    leaveConfirmed = true;
                                }
                                else
                                {
                                    requiredHours += 8;
                                    if (leaveRequest.isHourly)
                                        actualHours += leaveRequest.LeaveRequestBalance;
                                    leaveConfirmed = true;
                                }
                            }


                            // Here we should add mission confirmation

                            var entranceExitRecords = _entranceExitRecordRepository.GetAll().Where(x => x.EmployeeId == employee.Id && x.LogDate.Date == dt.Date).ToList().OrderBy(x => x.LogDate);
                            await _employeeCardRepository.EnsurePropertyLoadedAsync(employeeCard.EmployeeCard, x => x.AttendanceForm);

                            var attendanceForm = employeeCard.EmployeeCard.AttendanceForm;
                            await _attendanceFormRepository.EnsureCollectionLoadedAsync(attendanceForm,x => x.Workshops);

                            foreach(var eeRecord in entranceExitRecords)
                            {
                                double entryTimeLostHours = 0;
                                double exitTimeLostHours = 0;
                                if (eeRecord.RecordType == Enums.LogType.Entrance)
                                {
                                    foreach (var workshop in attendanceForm.Workshops)
                                    {
                                        await _workshopRepository.EnsureCollectionLoadedAsync(workshop, x => x.NormalShifts);
                                        foreach (var shift in workshop.NormalShifts)
                                        {
                                            if (eeRecord.LogTime >= shift.EntryTime && eeRecord.LogTime <= shift.ShiftRangeStartTime)
                                            {
                                                entryTimeLostHours = 0;
                                            }
                                            else
                                            {
                                                entryTimeLostHours = (eeRecord.LogTime - shift.EntryTime).TotalHours;
                                            }
                                        }
                                    }

                                }
                                if (eeRecord.RecordType == Enums.LogType.Exit)
                                {
                                    foreach (var workshop in attendanceForm.Workshops)
                                    {
                                        await _workshopRepository.EnsureCollectionLoadedAsync(workshop, x => x.NormalShifts);
                                        foreach (var shift in workshop.NormalShifts)
                                        {
                                            if (eeRecord.LogTime <= shift.ExitTime && eeRecord.LogTime >= shift.ShiftRangeEndTime)
                                            {
                                                entryTimeLostHours = 0;
                                            }
                                            else
                                            {
                                                entryTimeLostHours = (shift.ExitTime - eeRecord.LogTime).TotalHours;
                                            }
                                        }
                                    }

                                }
                                actualHours = 8 - entryTimeLostHours - exitTimeLostHours;
                            }


                            employeeCard.TotalRequiredWorkHours = requiredHours;
                            employeeCard.ActualTotalWorkHours = actualHours;
                            employeeCard.isCalculated = true;

                            var financialCard = _financialCardRepository.GetAllList().FirstOrDefault(x => x.EmployeeId == employee.Id);
                            double empSalaryPerHour = (financialCard.Salary / 30) / 8;


                            if (employeeCard.TotalRequiredWorkHours < employeeCard.ActualTotalWorkHours)
                            {
                                double benefitHours = employeeCard.ActualTotalWorkHours - employeeCard.TotalRequiredWorkHours;
                                BenefitCard benefitCard = new BenefitCard()
                                {
                                    isCalculatedInPayrollSystem = false,
                                    Name = "Benefit For Extra Time",
                                    Value = benefitHours * empSalaryPerHour,
                                };
                            }
                            else if (employeeCard.TotalRequiredWorkHours > employeeCard.ActualTotalWorkHours)
                            {
                                double deductionHours =  employeeCard.TotalRequiredWorkHours - employeeCard.ActualTotalWorkHours;

                                DeductionCard benefitCard = new DeductionCard()
                                {
                                    isCalculatedInPayrollSystem = false,
                                    Name = "Deduction For Less Time",
                                    Value = deductionHours * empSalaryPerHour,
                                };
                            }


                            await _attendanceMonthlyCardRepository.UpdateAsync(employeeCard);


                            // Check if this employee has a Leave in this day (hourly - daily) if hourly set these hours in variable
                            // if not Check if this employee has a mission in this day (hourly - daily) if hourly set these hours in variable
                            // Check the entrance exit record and get the total hours and compare with the employee normal shift
                            // if the employee entrance and exit hours bigger than the shift add the extra as benefits
                            // if smaller add the diffrence as deduction
                            // set the actual hours and required hours in the card
                            // continue
                            // when all the dates completed set all the monthly card as calculated
                            // done!
                        }
                    }
                }
            }
        }

        public async Task Delete(Guid id)
        {
            await _attendanceRecordRepository.DeleteAsync(id);
        }

        public async Task GenerateMonthlyCards(Guid id, List<Guid> employeeCardsIds)
        {
            var record = await _attendanceRecordRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (record != null)
            {
                await _attendanceRecordRepository.EnsureCollectionLoadedAsync(record, x => x.AttendanceMonthlyCards);
                if(record.AttendanceMonthlyCards == null)
                {
                    record.AttendanceMonthlyCards = new List<AttendanceMonthlyCard>();
                }
                foreach(var employeeCardId in employeeCardsIds)
                {
                    AttendanceMonthlyCard attendanceMonthlyCard = new AttendanceMonthlyCard()
                    {
                        EmployeeCardId = employeeCardId,
                        TotalRequiredWorkHours = 0,
                        ActualTotalWorkHours = 0,
                        isCalculated = false,
                    };
                    record.AttendanceMonthlyCards.Add(attendanceMonthlyCard);
                }
                await _attendanceRecordRepository.UpdateAsync(record);
            }
        }

        public async Task<List<AttendanceRecord>> GetAll()
        {
            return _attendanceRecordRepository.GetAllIncluding(x => x.AttendanceMonthlyCards).ToList();
        }

        public async Task<AttendanceRecord> GetbyId(Guid id)
        {
            AttendanceRecord attendanceRecord = await _attendanceRecordRepository.GetAsync(id);
            if (attendanceRecord != null)
            {
                await _attendanceRecordRepository.EnsureCollectionLoadedAsync(attendanceRecord, x => x.AttendanceMonthlyCards);
            }
            return attendanceRecord;
        }

        public async Task<AttendanceRecord> Insert(AttendanceRecord attendanceRecord)
        {
            return await _attendanceRecordRepository.InsertAsync(attendanceRecord);
        }

        public async Task<AttendanceRecord> Update(AttendanceRecord attendanceRecord)
        {
            return await _attendanceRecordRepository.UpdateAsync(attendanceRecord);
        }
    }
}
