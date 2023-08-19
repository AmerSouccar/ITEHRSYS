using Abp.Domain.Repositories;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Services
{
    public class MonthDomainService : IMonthDomainService
    {
        private readonly IRepository<Month,Guid> _monthRepository;
        private readonly IRepository<FinancialCard, Guid> _financialCardRepository;
        private readonly IRepository<EmployeeCard, Guid> _employeeCardRepository;
        private readonly IRepository<MonthlyCard, Guid> _monthyCardsRepository;
        private readonly IRepository<BenefitCard, Guid> _benefitCardRepository;
        private readonly IRepository<DeductionCard, Guid> _deductionCardRepository;


        public MonthDomainService(IRepository<Month, Guid> monthRepository, IRepository<FinancialCard, Guid> financialCardRepository, IRepository<EmployeeCard, Guid> employeeCardRepository, IRepository<MonthlyCard, Guid> monthyCardsRepository, IRepository<BenefitCard, Guid> benefitCardRepository, IRepository<DeductionCard, Guid> deductionCardRepository)
        {
            _monthRepository = monthRepository;
            _financialCardRepository = financialCardRepository;
            _employeeCardRepository = employeeCardRepository;
            _monthyCardsRepository = monthyCardsRepository;
            _benefitCardRepository = benefitCardRepository;
            _deductionCardRepository = deductionCardRepository;
        }

        public async Task CalculateMonth(Guid id)
        {
            var month = await _monthRepository.GetAsync(id);
            if(month != null)
            {
                await _monthRepository.EnsureCollectionLoadedAsync(month, x => x.MonthlyCards);
               foreach(var card in month.MonthlyCards)
                {
                    await _monthyCardsRepository.EnsurePropertyLoadedAsync(card, x => x.EmployeeCard);
                    await _employeeCardRepository.EnsurePropertyLoadedAsync(card.EmployeeCard, x => x.Position);
                    var financialCard = _financialCardRepository.GetAllList().FirstOrDefault(x => x.EmployeeId == card.EmployeeCard.EmployeeId);
                    double empSalaryPerHour = (financialCard.Salary / 30) / card.EmployeeCard.Position.WorkingHours;
                    var benefitCards = _benefitCardRepository.GetAll().Where(x => x.isCalculatedInPayrollSystem == false && x.EmployeeId == card.EmployeeCard.EmployeeId);
                    var deductionCards = _deductionCardRepository.GetAll().Where(x => x.isCalculatedInPayrollSystem == false && x.EmployeeId == card.EmployeeCard.EmployeeId);
                    double totalSumBalance = 0;
                    foreach (var bcard in benefitCards)
                    {
                        totalSumBalance += bcard.Value;
                    }
                    foreach (var dcard in deductionCards)
                    {
                        totalSumBalance -= dcard.Value;
                    }
                    double finalSalary = financialCard.Salary + totalSumBalance;
                    card.Salary = finalSalary;
                    card.Calculated = true;
                }
                var notCalculated = month.MonthlyCards.Any(x => x.Calculated == false);
                month.isCalculated = !notCalculated;
                await _monthRepository.UpdateAsync(month);
            }
        }

        public async Task Delete(Guid id)
        {
           await _monthRepository.DeleteAsync(id);
        }

        public Task GenerateMonthlyCards(Guid id, List<Guid> employeeIds)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Month> GetAll()
        {
            return _monthRepository.GetAllIncluding(x => x.MonthlyCards);
        }

        public async Task<Month> GetbyId(Guid id)
        {
            Month month = await _monthRepository.GetAsync(id);
            if (month != null)
            {
                await _monthRepository.EnsureCollectionLoadedAsync(month, x => x.MonthlyCards);
            }
            return month;
        }

        public async Task<Month> Insert(Month month)
        {
            return await _monthRepository.InsertAsync(month);
        }

        public async Task<Month> Update(Month month)
        {
            return await _monthRepository.UpdateAsync(month);

        }
    }
}
