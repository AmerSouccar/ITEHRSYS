using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Experiences.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Map
{
    public class ExperienceMapProfile :Profile
    {
        public ExperienceMapProfile()
        {
            CreateMap<Experience, ReadExperienceDto>();
            CreateMap<ReadExperienceDto, Experience>();
            CreateMap<Experience, InsertExperienceDto>();
            CreateMap<InsertExperienceDto, Experience>();
            CreateMap<Experience, UpdateExperienceDto>();
            CreateMap<UpdateExperienceDto, Experience>();
        }
    }
}
