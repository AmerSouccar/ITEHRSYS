using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadWorkflowSettingDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var workflowSettings = _workflowSettingDomainService.GetAll();
            int total = workflowSettings.Count();
            workflowSettings = workflowSettings.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadWorkflowSettingDto>>(workflowSettings.ToList());
            return new PagedResultDto<ReadWorkflowSettingDto>(total, list);
        }

        public async Task<ReadWorkflowSettingDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadWorkflowSettingDto>(await _workflowSettingDomainService.GetbyId(id));
        }

        public async Task<UpdateWorkflowSettingDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateWorkflowSettingDto>(await _workflowSettingDomainService.GetbyId(id));
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
