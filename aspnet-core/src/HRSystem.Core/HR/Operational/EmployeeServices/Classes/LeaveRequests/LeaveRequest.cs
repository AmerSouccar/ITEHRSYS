using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests
{
    public class LeaveRequest : FullAuditedAggregateRoot<Guid>
    {
        #region LeaveSetting
        [ForeignKey("LeaveSetting")]
        public Guid LeaveSettingId { get; set; }
        public LeaveSetting LeaveSetting { get; set; }
        #endregion
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double LeaveRequestBalance
        {
            get
            {
                return EndDate.Subtract(StartDate).TotalDays;
            }
        }
        public string Description { get; set; }
    }
}
