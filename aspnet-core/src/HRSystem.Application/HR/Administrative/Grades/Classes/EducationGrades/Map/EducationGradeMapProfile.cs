using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Map
{
    public class EducationGradeMapProfile :Profile
    {
        public EducationGradeMapProfile()
        {
            CreateMap<EducationGrade, ReadEducationGradeDto>();
            CreateMap<ReadEducationGradeDto, EducationGrade>();
            CreateMap<EducationGrade, InsertEducationGradeDto>();
            CreateMap<InsertEducationGradeDto, EducationGrade>();
            CreateMap<EducationGrade, UpdateEducationGradeDto>();
            CreateMap<UpdateEducationGradeDto, EducationGrade>();
        }
    }
}
