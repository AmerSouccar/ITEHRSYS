using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Map
{
    public class LanguageMapProfile :Profile
    {
        {
            public LanguageMapProfile()
            {
                CreateMap<Language, ReadLanguageDto>();
                CreateMap<ReadLanguageDto, Language>();
                CreateMap<Language, InsertLanguageDto>();
                CreateMap<InsertLanguageDto, Language>();
                CreateMap<Language, UpdateLanguageDto>();
                CreateMap<UpdateLanguageDto, Language>();
            }
        }
    }
}
