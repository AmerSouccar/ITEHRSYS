using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Map
{
    public class EducationMapProfile :Profile
    {
        public EducationMapProfile()
        {
            CreateMap<Education, ReadEducationDto>();
            CreateMap<ReadEducationDto, Education>();
            CreateMap<Education, InsertEducationDto>();
            CreateMap<InsertEducationDto, Education>();
            CreateMap<Education, UpdateEducationDto>();
            CreateMap<UpdateEducationDto, Education>();
        }
    }
}
