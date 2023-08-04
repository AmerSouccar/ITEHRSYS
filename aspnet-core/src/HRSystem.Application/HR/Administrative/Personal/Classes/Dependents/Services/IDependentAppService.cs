using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Services
{
    public interface IDependentAppService :IApplicationService
    {
        public PagedResultDto<ReadDependentDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadDependentDto> GetbyId(Guid id);
        public Task<InsertDependentDto> Insert(InsertDependentDto dependent);
        public Task<UpdateDependentDto> Update(UpdateDependentDto dependent);
        public Task Delete(Guid id);
    }
}
