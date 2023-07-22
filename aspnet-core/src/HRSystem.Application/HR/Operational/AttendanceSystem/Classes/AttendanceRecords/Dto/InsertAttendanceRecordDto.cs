using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto
{
    public class InsertAttendanceRecordDto :EntityDto<Guid>
    {
        public int Year { get; set; }
        public MonthName Month { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Note { get; set; }
        public bool isCalculated { get; set; }
    }
}
