using Abp.Domain.Repositories;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Services
{
    public class WorkflowDomainService : IWorkflowDomainService
    {
        private readonly IRepository<Workflow,Guid> _workflowRepository;

        public WorkflowDomainService(IRepository<Workflow, Guid> workflowRepository)
        {
            _workflowRepository = workflowRepository;
        }

        public async Task Delete(Guid id)
        {
            await _workflowRepository.DeleteAsync(id);
        }

        public async Task<List<Workflow>> GetAll()
        {
            return _workflowRepository.GetAllIncluding(x => x.Creator, x => x.FirstUser, x => x.CurrentUser, x => x.TargetUser).ToList();
        }

        public async Task<Workflow> GetbyId(Guid id)
        {
            Workflow workflow = await _workflowRepository.GetAsync(id);
            if (workflow != null)
            {
                await _workflowRepository.EnsurePropertyLoadedAsync(workflow, x => x.Creator);
                await _workflowRepository.EnsurePropertyLoadedAsync(workflow, x => x.FirstUser);
                await _workflowRepository.EnsurePropertyLoadedAsync(workflow, x => x.CurrentUser);
                await _workflowRepository.EnsurePropertyLoadedAsync(workflow, x => x.TargetUser);



            }
            return workflow;
        }

        public async Task<Workflow> Insert(Workflow workflow)
        {
            return await  _workflowRepository.InsertAsync(workflow);
        }

        public async Task<Workflow> Update(Workflow workflow)
        {
            return await _workflowRepository.UpdateAsync(workflow);

        }
    }
}
