using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto
{
    public class UpdateAttendanceRecordDto :EntityDto<Guid>
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Note { get; set; }
        public bool isCalculated { get; set; }
    }
}
