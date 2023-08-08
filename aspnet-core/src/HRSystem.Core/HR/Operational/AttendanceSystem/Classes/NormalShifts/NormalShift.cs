using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts
{
    public class NormalShift : FullAuditedAggregateRoot<Guid>
    {
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime ShiftRangeStartTime { get; set; }
        public DateTime ShiftRangeEndTime { get; set; }
    }
}
