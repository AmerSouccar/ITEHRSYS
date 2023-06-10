using Abp.Domain.Entities.Auditing;
using HRSystem.Authorization.Users;
using HRSystem.HR.Operational.Workflows.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow
{
    public class Workflow : FullAuditedAggregateRoot<Guid>
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public WorkflowStatus Status { get; set; }
        public WorkflowType Type { get; set; }
        public User Creator { get; set; }
        public User? FirstUser { get; set; }
        public User? CurrentUser { get; set; }
        public User? TargetUser { get; set; }
    }
}
