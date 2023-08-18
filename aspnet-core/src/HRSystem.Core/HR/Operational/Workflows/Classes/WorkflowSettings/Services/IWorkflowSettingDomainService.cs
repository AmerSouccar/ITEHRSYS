using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Services
{
    public interface IWorkflowSettingDomainService :IDomainService
    {
        public IQueryable<WorkflowSetting> GetAll();
        public Task<WorkflowSetting> GetbyId(Guid id);
        public Task<WorkflowSetting> Insert(WorkflowSetting workflowSetting);
        public Task<WorkflowSetting> Update(WorkflowSetting workflowSetting);
        public Task Delete(Guid id);
    }
}
