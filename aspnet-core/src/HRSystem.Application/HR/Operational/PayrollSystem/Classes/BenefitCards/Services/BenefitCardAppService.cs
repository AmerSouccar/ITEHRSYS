using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadBenefitCardDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var benefitCards = _benefitCarddomainService.GetAll();
            int total = benefitCards.Count();
            benefitCards = benefitCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadBenefitCardDto>>(benefitCards.ToList());
            return new PagedResultDto<ReadBenefitCardDto>(total, list);
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
