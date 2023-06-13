using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings
{
    public class LeaveSetting : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        #region EmployeeCard
        [ForeignKey("EmployeeCard")]
        public Guid EmployeeCardId { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        #endregion
        #region WorkflowSetting
        [ForeignKey("WorkflowSetting")]
        public Guid WorkflowSettingId { get; set; }
        public WorkflowSetting WorkflowSetting { get; set; }
        #endregion
        public string Description { get; set; }
    }
}
