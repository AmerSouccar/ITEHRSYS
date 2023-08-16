using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto
{
    public class ReadWorkshopDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public Guid AttendanceFormId { get; set; }
        //public ReadAttendanceFormDto AttendanceForm { get; set; }
        public List<ReadNormalShiftDto> NormalShifts { get; set; }
    }
}
