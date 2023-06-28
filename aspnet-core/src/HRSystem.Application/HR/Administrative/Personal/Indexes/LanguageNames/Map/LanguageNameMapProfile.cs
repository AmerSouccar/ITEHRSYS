using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Map
{
    public class LanguageNameMapProfile : Profile
    {
        public LanguageNameMapProfile()
        {
            CreateMap<LanguageName, LanguageNameDto>();
            CreateMap<LanguageNameDto, LanguageName>();
        }
    }
}
