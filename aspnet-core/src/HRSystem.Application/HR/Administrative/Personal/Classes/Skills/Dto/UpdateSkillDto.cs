﻿using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Dto
{
    public class UpdateSkillDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public string SkillName { get; set; }
        public Guid LevelId { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
    }
}
