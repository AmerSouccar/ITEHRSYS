using Abp.Application.Services;
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
    public interface IDeductionCardAppService :IApplicationService
    {
        public PagedResultDto<ReadDeductionCardDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadDeductionCardDto> GetbyId(Guid id);
        public Task<InsertDeductionCardDto> Insert(InsertDeductionCardDto deductionCard);
        public Task<UpdateDeductionCardDto> Update(UpdateDeductionCardDto deductionCard);
        public Task Delete(Guid id);
    }
}
