using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords
{
    public class AttendanceRecord : FullAuditedAggregateRoot<Guid>
    {
        public int Year { get; set; }
        public MonthName Month { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Note { get; set; }
    }
}
