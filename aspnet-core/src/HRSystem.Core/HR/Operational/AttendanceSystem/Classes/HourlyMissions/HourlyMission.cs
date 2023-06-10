using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions
{
    public class HourlyMission : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public bool isTransferd { get; set; }
        public Status Status { get; set; }  
    }
}
