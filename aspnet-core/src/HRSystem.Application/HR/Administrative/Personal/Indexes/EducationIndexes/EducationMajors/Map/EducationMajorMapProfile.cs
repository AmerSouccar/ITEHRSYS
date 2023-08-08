using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Map
{
    public class EducationMajorMapProfile : Profile
    {
        public EducationMajorMapProfile ()  
        {
            CreateMap<EducationMajor, EducationMajorDto>();
            CreateMap<EducationMajorDto, EducationMajor>();

        }
    }
}
