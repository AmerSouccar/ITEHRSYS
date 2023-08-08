using Abp.Domain.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Services
{
    public interface IFinancialCardDomainService :IDomainService
    {
        public Task<List<FinancialCard>> GetAll();
        public Task<FinancialCard> GetbyId(Guid id);
        public Task<FinancialCard> Insert(FinancialCard financialCard);
        public Task<FinancialCard> Update(FinancialCard financialCard);
        public Task Delete(Guid id);
    }
}
