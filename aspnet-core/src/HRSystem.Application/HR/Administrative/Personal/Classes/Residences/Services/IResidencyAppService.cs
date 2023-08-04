using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Services
{
    public interface IResidencyAppService : IApplicationService
    {
        public PagedResultDto<ReadResidencyDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadResidencyDto> GetbyId(Guid id);
        public Task<InsertResidencyDto> Insert(InsertResidencyDto residency);
        public Task<UpdateResidencyDto> Update(UpdateResidencyDto residency);
        public Task Delete(Guid id);
    }
}
