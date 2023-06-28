using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using AutoMapper;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Map
{
    public class ScoreTypeMapProfile :Profile
    {
        public ScoreTypeMapProfile()
        {
            CreateMap<ScoreType, ScoreTypeDto>();
            CreateMap<ScoreTypeDto, ScoreType>();
        }
    }
}
