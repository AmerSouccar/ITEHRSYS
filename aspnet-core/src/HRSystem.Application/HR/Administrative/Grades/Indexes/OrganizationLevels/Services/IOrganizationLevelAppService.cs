using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Services
{
    public interface IOrganizationLevelAppService :IApplicationService
    {
        public PagedResultDto<ReadOrganizationLevelDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadOrganizationLevelDto> GetbyId(Guid id);
        public Task<InsertOrganizationLevelDto> Insert(InsertOrganizationLevelDto organizationLevel);
        public Task<UpdateOrganizationLevelDto> Update(UpdateOrganizationLevelDto organizationLevel);
        public Task Delete(Guid id);
    }
}
