using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
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
        public Employee Employee { get; set; }
        public DateTime LogTime { get; set; }
        public LogType RecordType { get; set; }
        public string Notes { get; set; }
        public bool isChecked { get; set; }
    }
}
