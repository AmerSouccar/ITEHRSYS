using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Dto;
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

        public async Task<List<ReadDeductionCardDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadDeductionCardDto>>(await _deductionCarddomainService.GetAll());
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
