using Abp.Domain.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Services
{
    public interface IMonthlyCardDominService :IDomainService
    {
        public IQueryable<MonthlyCard> GetAll();
        public IQueryable<MonthlyCard> GetAllbyId(Guid id);
        public Task<MonthlyCard> GetbyId(Guid id);
        public Task<MonthlyCard> Insert(MonthlyCard monthlyCard);
        public Task<MonthlyCard> Update(MonthlyCard monthlyCard);
        public Task Delete(Guid id);
    }
}
