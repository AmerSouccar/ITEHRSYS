using Abp.Domain.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Services
{
    public interface IWorkflowDomainService :IDomainService
    {
        public Task<List<Workflow>> GetAll();
        public Task<Workflow> GetbyId(Guid id);
        public Task<Workflow> Insert(Workflow workflow);
        public Task<Workflow> Update(Workflow workflow);
        public Task Delete(Guid id);
    }
}
