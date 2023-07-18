using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Services
{
    public class BenefitCardDomainService : IBenefitCardDomainService
    {
        private readonly IRepository<BenefitCard,Guid> _benefitCardRepository;

        public BenefitCardDomainService(IRepository<BenefitCard, Guid> benefitCardRepository)
        {
            _benefitCardRepository = benefitCardRepository;
        }

        public async Task Delete(Guid id)
        {
            await _benefitCardRepository.DeleteAsync(id);
        }

        public async Task<List<BenefitCard>> GetAll()
        {
            return await _benefitCardRepository.GetAllListAsync();
        }

        public Task<BenefitCard> GetbyId(Guid id)
        {
            return _benefitCardRepository.GetAsync(id);
        }

        public async Task<BenefitCard> Insert(BenefitCard benefitCard)
        {
            return await _benefitCardRepository.InsertAsync(benefitCard);
        }

        public async Task<BenefitCard> Update(BenefitCard benefitCard)
        {
            return await _benefitCardRepository.UpdateAsync(benefitCard);

        }
    }
}
