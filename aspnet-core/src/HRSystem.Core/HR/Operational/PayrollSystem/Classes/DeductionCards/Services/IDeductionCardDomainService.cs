using Abp.Domain.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Services
{
    public interface IDeductionCardDomainService :IDomainService
    {
        public Task<List<DeductionCard>> GetAll();
        public Task<DeductionCard> GetbyId(Guid id);
        public Task<DeductionCard> Insert(DeductionCard deductionCard);
        public Task<DeductionCard> Update(DeductionCard deductionCard);
        public Task Delete(Guid id);
    }
}
