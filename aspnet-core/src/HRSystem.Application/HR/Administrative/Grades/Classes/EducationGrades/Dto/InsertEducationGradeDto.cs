using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto
{
    public class InsertEducationGradeDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
        public int? Currency { get; set; }
        public string? Description { get; set; }
    }
}
