﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto
{
    public class ReadAttendanceFormDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public List<ReadAttendanceFormDto> Workshops { get; set; }
    }
}
