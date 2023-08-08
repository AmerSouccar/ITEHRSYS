using Abp.Domain.Entities.Auditing;
using HRSystem.Authorization.Users;
using HRSystem.HR.Operational.Workflows.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        #region Creator
        [ForeignKey("Creator")]
        public long CreatorId { get; set; }
        public User Creator { get; set; }
        #endregion
        #region FirstUser
        [ForeignKey("FirstUser")]
        public long FirstUserId { get; set; }
        public User? FirstUser { get; set; }
        #endregion
        #region CurrentUser
        [ForeignKey("CurrentUser")]
        public long CurrentUserId { get; set; }
        public User? CurrentUser { get; set; }
        #endregion
        #region TargetUser
        [ForeignKey("TargetUser")]
        public long TargetUserId { get; set; }
        public User? TargetUser { get; set; }
        #endregion
    }
}
