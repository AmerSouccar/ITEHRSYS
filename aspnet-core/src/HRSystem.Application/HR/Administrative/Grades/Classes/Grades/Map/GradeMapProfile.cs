using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Map
{
    public class GradeMapProfile :Profile
    {
        public GradeMapProfile()
        {
            CreateMap<Grade, ReadGradeDto>();
            CreateMap<ReadGradeDto, Grade>();
            CreateMap<Grade, InsertGradeDto>();
            CreateMap<InsertGradeDto, Grade>();
            CreateMap<Grade, UpdateGradeDto>();
            CreateMap<UpdateGradeDto, Grade>();
        }
    }
}
