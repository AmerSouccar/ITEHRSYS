using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using HRSystem.HR.Operational.EmployeeServices.Enums;
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
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isHourly { get; set; }
        public DateTime? StartHour { get; set; }
        public DateTime? EndHour { get; set; }
        public LeaveRequestStatus LeaveRequestStatus { get; set; }
        public double LeaveRequestBalance
        {
            get
            {
                if(isHourly)
                {
                    double spentHours = EndDate.Subtract(StartDate).TotalHours;
                    double spentDays = spentHours / 8;
                    return spentDays;
                }
                else
                return EndDate.Subtract(StartDate).TotalDays;
            }
        }
        public string Description { get; set; }
    }
}
