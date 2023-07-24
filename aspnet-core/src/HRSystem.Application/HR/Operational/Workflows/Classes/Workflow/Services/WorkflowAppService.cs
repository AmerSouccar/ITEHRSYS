using HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto;
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

        public async Task<List<ReadWorkflowDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadWorkflowDto>>(await _workflowDomainService.GetAll());
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
