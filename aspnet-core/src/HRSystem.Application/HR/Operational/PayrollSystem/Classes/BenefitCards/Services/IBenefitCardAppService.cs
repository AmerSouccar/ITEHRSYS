using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Services
{
    public interface IBenefitCardAppService : IApplicationService
    {
        public PagedResultDto<ReadBenefitCardDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadBenefitCardDto> GetbyId(Guid id);
        public Task<InsertBenefitCardDto> Insert(InsertBenefitCardDto benefitCard);
        public Task<UpdateBenefitCardDto> Update(UpdateBenefitCardDto benefitCard);
        public Task Delete(Guid id);
    }
}
