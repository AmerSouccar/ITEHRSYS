using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Services
{
    public class WorkflowSettingAppService : HRSystemAppServiceBase, IWorkflowSettingAppService
    {
        private readonly IWorkflowSettingDomainService _workflowSettingDomainService;

        public WorkflowSettingAppService(IWorkflowSettingDomainService workflowSettingDomainService)
        {
            _workflowSettingDomainService = workflowSettingDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _workflowSettingDomainService.Delete(id);
        }

        public async Task<List<ReadWorkflowSettingDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadWorkflowSettingDto>>(await _workflowSettingDomainService.GetAll());
        }

        public async Task<ReadWorkflowSettingDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadWorkflowSettingDto>(await _workflowSettingDomainService.GetbyId(id));
        }

        public async Task<InsertWorkflowSettingDto> Insert(InsertWorkflowSettingDto workflowSetting)
        {
            return ObjectMapper.Map<InsertWorkflowSettingDto>(await _workflowSettingDomainService.Insert(ObjectMapper.Map<WorkflowSetting>(workflowSetting)));
        }

        public async Task<UpdateWorkflowSettingDto> Update(UpdateWorkflowSettingDto workflowSetting)
        {
            return ObjectMapper.Map<UpdateWorkflowSettingDto>(await _workflowSettingDomainService.Update(ObjectMapper.Map<WorkflowSetting>(workflowSetting)));

        }
    }
}
