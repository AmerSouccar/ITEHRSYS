using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto
{
    public class InsertEntranceExitRecordDto :EntityDto<Guid>
    {
        public string LogDate { get; set; }
        public Guid EmployeeId { get; set; }
        public string LogTime { get; set; }
        public int RecordType { get; set; }
        public string Notes { get; set; }
        public bool isChecked { get; set; }
    }
}
