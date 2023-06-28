using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Map
{
    public class RankMapProfile :Profile
    {
        public RankMapProfile()
        {
            CreateMap<Rank,RankDto>();
            CreateMap<RankMapProfile, Rank>();
        }
    }
}
