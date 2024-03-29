﻿using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades
{
    public class EducationGrade : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
        public Currency? Currency { get; set; }
        public string? Description { get; set; }
    }
}
