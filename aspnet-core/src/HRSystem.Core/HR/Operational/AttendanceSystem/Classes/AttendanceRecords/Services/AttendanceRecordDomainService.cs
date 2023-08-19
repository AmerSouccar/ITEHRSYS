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
        private readonly IRepository<BenefitCard,Guid> _benefitCardRepository;
        private readonly IRepository<DeductionCard,Guid> _deductionCardRepository;

        public AttendanceRecordDomainService(IRepository<AttendanceRecord, Guid> attendanceRecordRepository, IRepository<EmployeeCard, Guid> employeeCardRepository, IRepository<Employee, Guid> employeeRepository, IRepository<AttendanceMonthlyCard, Guid> attendanceMonthlyCardRepository, ICompanyHolidayDomainService companyHolidayDomainService, IFixedHolidayDomainService fixedHolidayDomainService, IChangeableHolidayDomainService changeableHolidayDomainService, IRepository<LeaveRequest, Guid> leaveRequestRepository, IRepository<EntranceExitRecord, Guid> entranceExitRecordRepository, IRepository<AttendanceForm, Guid> attendanceFormRepository, IRepository<Workshop, Guid> workshopRepository, IRepository<NormalShift, Guid> normalShiftRepository, IRepository<FinancialCard, Guid> financialCardRepository, IRepository<BenefitCard, Guid> benefitCardRepository, IRepository<DeductionCard, Guid> deductionCardRepository)
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
            _benefitCardRepository = benefitCardRepository;
            _deductionCardRepository = deductionCardRepository;
        }

        public async Task OldCalculateMonth(Guid id)
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
                        //if(employeeCard.isCalculated)
                        //{
                        //    continue;
                        //}
                        var empC = employeeCard.EmployeeCard;
                        await _employeeCardRepository.EnsurePropertyLoadedAsync(empC, x => x.Employee);
                        var employee = employeeCard.EmployeeCard.Employee;

                        if (employee != null)
                        {
                            double requiredHours = 0;
                            double actualHours = 0;
                            bool holidayConfirmed = false;

                            var companyHolidays = _companyHolidayDomainService.GetAll();
                            if (!holidayConfirmed && companyHolidays.Any(x => x.DayOfWeek.ToString() == dt.Day.ToString()))
                            {
                                requiredHours += 8;
                                actualHours += 8;
                                holidayConfirmed = true;
                            }
                            var fixedHolidays = _fixedHolidayDomainService.GetAll();
                            if(!holidayConfirmed && fixedHolidays.Any(x => x.Month.ToString() == dt.Month.ToString() && x.Day.ToString() == dt.Day.ToString()))
                            {
                                requiredHours += 8;
                                actualHours += 8;
                                holidayConfirmed = true;
                            }
                            var changeableHolidays = _changeableHolidayDomainService.GetAll();
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
                            if(attendanceForm == null)
                            {
                                continue;
                            }
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
                var notCalculated = record.AttendanceMonthlyCards.Any(x => x.isCalculated == false);
                record.isCalculated = !notCalculated;
                await _attendanceRecordRepository.UpdateAsync(record);
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

        public  IQueryable<AttendanceRecord> GetAll()
        {
            return _attendanceRecordRepository.GetAllIncluding(x => x.AttendanceMonthlyCards);
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

        public async Task CalculateMonth(Guid id)
        {
            var record = await _attendanceRecordRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (record != null)
            {
                await _attendanceRecordRepository.EnsureCollectionLoadedAsync(record, x => x.AttendanceMonthlyCards);
                foreach (var attendanceMonthlyCard in record.AttendanceMonthlyCards)
                {
                    if(attendanceMonthlyCard.isCalculated)
                    {
                        continue;
                    }
                    await _attendanceMonthlyCardRepository.EnsurePropertyLoadedAsync(attendanceMonthlyCard, x => x.EmployeeCard);
                    await _employeeCardRepository.EnsurePropertyLoadedAsync(attendanceMonthlyCard.EmployeeCard, x => x.Employee);
                    await _employeeCardRepository.EnsurePropertyLoadedAsync(attendanceMonthlyCard.EmployeeCard, x => x.AttendanceForm);
                    await _employeeCardRepository.EnsurePropertyLoadedAsync(attendanceMonthlyCard.EmployeeCard, x => x.Position);
                    var employeePosition = attendanceMonthlyCard.EmployeeCard.Position;
                    double totalRequiredHoursPerDay = 0;
                    double actualRequiredHours = 0;
                    double actualAttendanceHours = 0;
                    if (employeePosition.Per == Administrative.JobDesc.Enums.HoursPer.Day)
                    {
                        totalRequiredHoursPerDay = employeePosition.WorkingHours ;
                    }
                    else if(employeePosition.Per == Administrative.JobDesc.Enums.HoursPer.Week)
                    {
                        totalRequiredHoursPerDay = (employeePosition.WorkingHours/7);
                    }
                    else if(employeePosition.Per == Administrative.JobDesc.Enums.HoursPer.Month)
                    {
                        totalRequiredHoursPerDay = (employeePosition.WorkingHours / 30);
                    }
                    else if(employeePosition.Per == Administrative.JobDesc.Enums.HoursPer.Year)
                    {
                        totalRequiredHoursPerDay = (employeePosition.WorkingHours / 365);
                    }
                    for (DateTime dt = record.FromDate; dt < record.ToDate; dt = dt.AddDays(1))
                    {
                        //Check if Holiday
                        bool holidayConfirmed = false;
                        bool leaveConfirmed = false;
                        bool hourlyLeaveConfirmed = false;

                        //var companyHolidays = _companyHolidayDomainService.GetAll();
                        //if (!holidayConfirmed && companyHolidays.Any(x => x.DayOfWeek == dt.Day.ToString("dddd")))
                        //{
                        //    holidayConfirmed = true;
                        //}
                        var fixedHolidays = _fixedHolidayDomainService.GetAll();
                        if (!holidayConfirmed && fixedHolidays.Any(x => x.Month.ToString() == dt.Month.ToString() && x.Day.ToString() == dt.Day.ToString()))
                        {
                            holidayConfirmed = true;
                        }
                        var changeableHolidays = _changeableHolidayDomainService.GetAll();
                        if (!holidayConfirmed && changeableHolidays.Any(x => x.StartDate <= dt && x.EndDate >= dt))
                        {
                            holidayConfirmed = true;
                        }

                        if (holidayConfirmed)
                        {
                            actualRequiredHours += totalRequiredHoursPerDay;
                            actualAttendanceHours += totalRequiredHoursPerDay;
                            continue;
                        }

                        var leaveRequests = _leaveRequestRepository.GetAll().Where(x => x.EmployeeId == attendanceMonthlyCard.EmployeeCard.EmployeeId && x.StartDate <= dt && x.EndDate > dt).ToList();
                        foreach (var leaveRequest in leaveRequests)
                        {
                            await _leaveRequestRepository.EnsurePropertyLoadedAsync(leaveRequest, x => x.LeaveSetting);
                           if(leaveRequest.isHourly)
                            {
                                if(leaveRequest.LeaveSetting.isPaidLeave)
                                {
                                    actualRequiredHours += (totalRequiredHoursPerDay - leaveRequest.LeaveRequestBalance);
                                    hourlyLeaveConfirmed = true;
                                }
                            }
                           else if(!leaveRequest.isHourly)
                            {
                                if (leaveRequest.LeaveSetting.isPaidLeave)
                                {
                                    actualRequiredHours += totalRequiredHoursPerDay;
                                    actualAttendanceHours += totalRequiredHoursPerDay;
                                    leaveConfirmed = true;
                                }
                            }
                        }
                        if(!leaveConfirmed && !hourlyLeaveConfirmed)
                        {
                            actualRequiredHours += totalRequiredHoursPerDay;
                        }


                        var entranceExitRecords = _entranceExitRecordRepository.GetAll().Where(x => x.EmployeeId == attendanceMonthlyCard.EmployeeCard.EmployeeId && x.LogDate.Date == dt.Date).ToArray();
                        double thisDayWorkedHours = 0;
                        if(entranceExitRecords.Length > 0)
                        {
                            for(int i = 0; i <  entranceExitRecords.Length; i += 2)
                            {
                                thisDayWorkedHours += entranceExitRecords[i + 1].LogTime.TimeOfDay.Subtract(entranceExitRecords[i].LogTime.TimeOfDay).TotalHours;
                            }
                        }
                        actualAttendanceHours += thisDayWorkedHours;
                    }

                    var financialCard = _financialCardRepository.GetAllList().FirstOrDefault(x => x.EmployeeId == attendanceMonthlyCard.EmployeeCard.EmployeeId);
                    double empSalaryPerHour = (financialCard.Salary / 30) / attendanceMonthlyCard.EmployeeCard.Position.WorkingHours;

                    attendanceMonthlyCard.TotalRequiredWorkHours = actualRequiredHours;
                    attendanceMonthlyCard.ActualTotalWorkHours = actualAttendanceHours;
                    attendanceMonthlyCard.isCalculated = true;
                    await _attendanceMonthlyCardRepository.UpdateAsync(attendanceMonthlyCard);

                    if (attendanceMonthlyCard.TotalRequiredWorkHours < attendanceMonthlyCard.ActualTotalWorkHours)
                    {
                        double benefitHours = attendanceMonthlyCard.ActualTotalWorkHours - attendanceMonthlyCard.TotalRequiredWorkHours;
                        BenefitCard benefitCard = new BenefitCard()
                        {
                            isCalculatedInPayrollSystem = false,
                            Name = "Benefit For Extra Time",
                            Value = benefitHours * empSalaryPerHour,
                            EmployeeId = attendanceMonthlyCard.EmployeeCard.EmployeeId,
                        };
                        await _benefitCardRepository.InsertAsync(benefitCard);
                    }
                    else if (attendanceMonthlyCard.TotalRequiredWorkHours > attendanceMonthlyCard.ActualTotalWorkHours)
                    {
                        double deductionHours = attendanceMonthlyCard.TotalRequiredWorkHours - attendanceMonthlyCard.ActualTotalWorkHours;

                        DeductionCard deductionCard = new DeductionCard()
                        {
                            isCalculatedInPayrollSystem = false,
                            Name = "Deduction For Less Time",
                            Value = deductionHours * empSalaryPerHour,
                            EmployeeId = attendanceMonthlyCard.EmployeeCard.EmployeeId,
                        };
                        await _deductionCardRepository.InsertAsync(deductionCard);

                    }

                }
                var notCalculated = record.AttendanceMonthlyCards.Any(x => x.isCalculated == false);
                record.isCalculated = !notCalculated;
                await _attendanceRecordRepository.UpdateAsync(record);
            }
        }
    }
}
