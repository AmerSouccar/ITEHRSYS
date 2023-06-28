using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using AutoMapper;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Map
{
    public class NationalityMapProfile :Profile
    {
        public NationalityMapProfile()
        {
            CreateMap<Nationality, NationalityDto>();
            CreateMap<NationalityDto, Nationality>();
        }
    }
}
