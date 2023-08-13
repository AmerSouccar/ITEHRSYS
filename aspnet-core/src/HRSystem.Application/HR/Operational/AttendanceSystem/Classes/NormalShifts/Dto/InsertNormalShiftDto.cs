using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto
{
    public class InsertNormalShiftDto :EntityDto<Guid>
    {
        public DateTime EntryTime { get; set; }
        public Guid WorkshopId { get; set; }

        public DateTime ExitTime { get; set; }
        public DateTime ShiftRangeStartTime { get; set; }
        public DateTime ShiftRangeEndTime { get; set; }
    }
}
