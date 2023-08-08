using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Map
{
    public class UniversityMapProfile :Profile
    {
        public UniversityMapProfile()
        {
            CreateMap<University, UniversityDto>();
            CreateMap<UniversityDto, University>();
        }
    }
}
