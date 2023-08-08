using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays
{
    public class FixedHoliday : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public DateTime Month { get; set; }
        public int NumberofDays { get; set; }
    }
}
