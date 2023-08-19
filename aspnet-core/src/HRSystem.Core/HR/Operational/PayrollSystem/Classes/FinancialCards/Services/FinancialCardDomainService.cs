using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Services
{
    public class FinancialCardDomainService : IFinancialCardDomainService
    {
        private readonly IRepository<FinancialCard,Guid> _financialCardRepository;

        public FinancialCardDomainService(IRepository<FinancialCard, Guid> financialCardRepository)
        {
            _financialCardRepository = financialCardRepository;
        }

        public async Task Delete(Guid id)
        {
           await _financialCardRepository.DeleteAsync(id);
        }

        public IQueryable<FinancialCard> GetAll()
        {
            return _financialCardRepository.GetAllIncluding(x => x.Employee);
        }

        public async Task<FinancialCard> GetbyId(Guid id)
        {
            FinancialCard financialCard = await _financialCardRepository.GetAsync(id);
            if (financialCard != null)
            {
                await _financialCardRepository.EnsurePropertyLoadedAsync(financialCard, x => x.Employee);

            }
            return financialCard;
        }

        public async Task<FinancialCard> Insert(FinancialCard financialCard)
        {
           return await _financialCardRepository.InsertAsync(financialCard);
        }

        public async Task<FinancialCard> Update(FinancialCard financialCard)
        {
            return await _financialCardRepository.UpdateAsync(financialCard);

        }
    }
}
