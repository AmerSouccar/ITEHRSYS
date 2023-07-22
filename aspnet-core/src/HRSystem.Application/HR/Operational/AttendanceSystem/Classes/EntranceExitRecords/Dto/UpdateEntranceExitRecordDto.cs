using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto
{
    public class UpdateEntranceExitRecordDto :EntityDto<Guid>
    {
        public DateTime LogDate { get; set; }
        public string Day
        {
            get
            {
                return this.LogDate.Day.ToString();
            }
        }
        public Guid EmployeeId { get; set; }
        public DateTime LogTime { get; set; }
        public LogType RecordType { get; set; }
        public string Notes { get; set; }
        public bool isChecked { get; set; }
    }
}
