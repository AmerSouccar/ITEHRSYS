using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Services
{
    public class WorkflowSettingDomainService : IWorkflowSettingDomainService
    {
        private readonly IRepository<WorkflowSetting,Guid> _workflowSettingRepository;

        public WorkflowSettingDomainService(IRepository<WorkflowSetting, Guid> workflowSettingRepository)
        {
            _workflowSettingRepository = workflowSettingRepository;
        }

        public async Task Delete(Guid id)
        {
           await _workflowSettingRepository.DeleteAsync(id);
        }

        public IQueryable<WorkflowSetting> GetAll()
        {
           return _workflowSettingRepository.GetAll();
        }

        public async Task<WorkflowSetting> GetbyId(Guid id)
        {
            return await _workflowSettingRepository.GetAsync(id);
        }

        public async Task<WorkflowSetting> Insert(WorkflowSetting workflowSetting)
        {
            return await _workflowSettingRepository.InsertAsync(workflowSetting);
        }

        public async Task<WorkflowSetting> Update(WorkflowSetting workflowSetting)
        {
            return await _workflowSettingRepository.UpdateAsync(workflowSetting);

        }
    }
}
