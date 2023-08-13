using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts
{
    public class NormalShift : FullAuditedAggregateRoot<Guid>
    {
        public DateTime EntryTime { get; set; }
        #region Workshop
        [ForeignKey("Workshop")]
        public Guid WorkshopId{ get; set; }
        public Workshop Workshop { get; set; }
        #endregion
        public DateTime ExitTime { get; set; }
        public DateTime ShiftRangeStartTime { get; set; }
        public DateTime ShiftRangeEndTime { get; set; }
    }
}
