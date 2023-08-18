using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings
{
    public class WorkflowSetting : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public int Steps { get; set; }
    }
}
