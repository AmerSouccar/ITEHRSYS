using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Services
{
    public class DeductionCardAppService : HRSystemAppServiceBase, IDeductionCardAppService
    {
        private readonly IDeductionCardDomainService _deductionCarddomainService;

        public DeductionCardAppService(IDeductionCardDomainService deductionCarddomainService)
        {
            _deductionCarddomainService = deductionCarddomainService;
        }

        public async Task Delete(Guid id)
        {
            await _deductionCarddomainService.Delete(id);
        }

        public PagedResultDto<ReadDeductionCardDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var deductionCards = _deductionCarddomainService.GetAll();
            int total = deductionCards.Count();
            deductionCards = deductionCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadDeductionCardDto>>(deductionCards.ToList());
            return new PagedResultDto<ReadDeductionCardDto>(total, list);
        }

        public async Task<ReadDeductionCardDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadDeductionCardDto>(await _deductionCarddomainService.GetbyId(id));
        }

        public async Task<InsertDeductionCardDto> Insert(InsertDeductionCardDto deductionCard)
        {
            return ObjectMapper.Map<InsertDeductionCardDto>(await _deductionCarddomainService.Insert(ObjectMapper.Map<DeductionCard>(deductionCard)));
        }

        public async Task<UpdateDeductionCardDto> Update(UpdateDeductionCardDto deductionCard)
        {
            return ObjectMapper.Map<UpdateDeductionCardDto>(await _deductionCarddomainService.Update(ObjectMapper.Map<DeductionCard>(deductionCard)));

        }
    }
}
