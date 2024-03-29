﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto
{
    public class UpdatePositionDto :EntityDto<Guid>
    {
        public Guid JobDescriptionId { get; set; }
        public Guid PositionWorkTypeId { get; set; }
        public double WorkingHours { get; set; }
        public HoursPer Per { get; set; }
        public bool HasManager { get; set; }
        public Guid? ManagerJobTitleId { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
