using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Services
{
    public class WorkflowAppService : HRSystemAppServiceBase, IWorkflowAppService
    {
        private readonly IWorkflowDomainService _workflowDomainService;

        public WorkflowAppService(IWorkflowDomainService workflowDomainService)
        {
            _workflowDomainService = workflowDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _workflowDomainService.Delete(id);
        }

        public PagedResultDto<ReadWorkflowDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var workflows = _workflowDomainService.GetAll();
            int total = workflows.Count();
            workflows = workflows.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadWorkflowDto>>(workflows.ToList());
            return new PagedResultDto<ReadWorkflowDto>(total, list);
        }

        public async Task<ReadWorkflowDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadWorkflowDto>(await _workflowDomainService.GetbyId(id));
        }

        public async Task<InsertWorkflowDto> Insert(InsertWorkflowDto workflow)
        {
            return ObjectMapper.Map<InsertWorkflowDto>(await _workflowDomainService.Insert(ObjectMapper.Map<Workflow>(workflow)));
        }

        public async Task<UpdateWorkflowDto> Update(UpdateWorkflowDto workflow)
        {
            return ObjectMapper.Map<UpdateWorkflowDto>(await _workflowDomainService.Update(ObjectMapper.Map<Workflow>(workflow)));

        }
    }
}
