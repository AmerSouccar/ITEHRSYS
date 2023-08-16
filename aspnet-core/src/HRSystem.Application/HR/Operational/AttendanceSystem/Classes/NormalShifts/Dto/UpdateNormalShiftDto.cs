using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto
{
    public class UpdateNormalShiftDto :EntityDto<Guid>
    {
        public Guid WorkshopId { get; set; }
        public string EntryTime { get; set; }

        public string ExitTime { get; set; }
        public string ShiftRangeStartTime { get; set; }
        public string ShiftRangeEndTime { get; set; }
    }
}
