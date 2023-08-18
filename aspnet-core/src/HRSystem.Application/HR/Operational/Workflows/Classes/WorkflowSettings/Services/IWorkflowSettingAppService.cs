using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Services
{
    public interface IWorkflowSettingAppService : IApplicationService
    {
        public PagedResultDto<ReadWorkflowSettingDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadWorkflowSettingDto> GetbyId(Guid id);
        public Task<UpdateWorkflowSettingDto> GetForEdit(Guid id);
        public Task<InsertWorkflowSettingDto> Insert(InsertWorkflowSettingDto workflowSetting);
        public Task<UpdateWorkflowSettingDto> Update(UpdateWorkflowSettingDto workflowSetting);
        public Task Delete(Guid id);
    }
}
