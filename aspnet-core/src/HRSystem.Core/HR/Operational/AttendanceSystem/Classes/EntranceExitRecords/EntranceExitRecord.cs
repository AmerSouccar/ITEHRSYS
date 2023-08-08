using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords
{
    public class EntranceExitRecord : FullAuditedAggregateRoot<Guid>
    {
        public DateTime LogDate { get; set; }
        public string Day 
        { 
            get
            { 
                return this.LogDate.Day.ToString();
            } 
        }
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public DateTime LogTime { get; set; }
        public LogType RecordType { get; set; }
        public string Notes { get; set; }
        public bool isChecked { get; set; }
    }
}
