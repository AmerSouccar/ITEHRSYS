using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Services
{
    public class DeductionCardDomainService : IDeductionCardDomainService
    {
        private readonly IRepository<DeductionCard,Guid> _deductionCardRepository;

        public DeductionCardDomainService(IRepository<DeductionCard, Guid> deductionCardRepository)
        {
            _deductionCardRepository = deductionCardRepository;
        }

        public async Task Delete(Guid id)
        {
           await _deductionCardRepository.DeleteAsync(id);
        }

        public IQueryable<DeductionCard> GetAll()
        {
           return _deductionCardRepository.GetAll();
        }

        public async Task<DeductionCard> GetbyId(Guid id)
        {
            return await _deductionCardRepository.GetAsync(id);
        }

        public async Task<DeductionCard> Insert(DeductionCard deductionCard)
        {
            return await _deductionCardRepository.InsertAsync(deductionCard);
        }

        public async Task<DeductionCard> Update(DeductionCard deductionCard)
        {
            return await _deductionCardRepository.UpdateAsync(deductionCard);

        }
    }
}
