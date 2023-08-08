using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Services
{
    public interface IWorkflowSettingAppService : IApplicationService
    {
        public Task<List<ReadWorkflowSettingDto>> GetAll();
        public Task<ReadWorkflowSettingDto> GetbyId(Guid id);
        public Task<InsertWorkflowSettingDto> Insert(InsertWorkflowSettingDto workflowSetting);
        public Task<UpdateWorkflowSettingDto> Update(UpdateWorkflowSettingDto workflowSetting);
        public Task Delete(Guid id);
    }
}
