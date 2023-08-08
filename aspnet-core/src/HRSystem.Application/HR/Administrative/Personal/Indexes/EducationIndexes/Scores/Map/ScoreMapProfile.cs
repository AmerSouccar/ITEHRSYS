using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Map
{
    internal class ScoreMapProfile : Profile
    {
        public ScoreMapProfile()
        {
            CreateMap<Score, ScoreDto>();
            CreateMap<ScoreDto, Score>();
        }
    }
}
