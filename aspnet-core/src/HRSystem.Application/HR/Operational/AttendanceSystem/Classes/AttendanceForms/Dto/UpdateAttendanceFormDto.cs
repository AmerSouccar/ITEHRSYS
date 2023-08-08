using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto
{
    public class UpdateAttendanceFormDto : EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
