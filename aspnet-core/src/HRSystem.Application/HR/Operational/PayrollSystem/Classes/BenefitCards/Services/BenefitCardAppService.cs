using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Services
{
    public class BenefitCardAppService : HRSystemAppServiceBase, IBenefitCardAppService
    {
        private readonly IBenefitCardDomainService _benefitCarddomainService;

        public BenefitCardAppService(IBenefitCardDomainService benefitCarddomainService)
        {
            _benefitCarddomainService = benefitCarddomainService;
        }

        public async Task Delete(Guid id)
        {
            await _benefitCarddomainService.Delete(id);
        }

        public async Task<List<ReadBenefitCardDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadBenefitCardDto>>(await _benefitCarddomainService.GetAll());
        }

        public async Task<ReadBenefitCardDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadBenefitCardDto>(await _benefitCarddomainService.GetbyId(id));
        }

        public async Task<InsertBenefitCardDto> Insert(InsertBenefitCardDto benefitCard)
        {
            return ObjectMapper.Map<InsertBenefitCardDto>(await _benefitCarddomainService.Insert(ObjectMapper.Map<BenefitCard>(benefitCard)));
        }

        public async Task<UpdateBenefitCardDto> Update(UpdateBenefitCardDto benefitCard)
        {
            return ObjectMapper.Map<UpdateBenefitCardDto>(await _benefitCarddomainService.Update(ObjectMapper.Map<BenefitCard>(benefitCard)));

        }
    }
}
