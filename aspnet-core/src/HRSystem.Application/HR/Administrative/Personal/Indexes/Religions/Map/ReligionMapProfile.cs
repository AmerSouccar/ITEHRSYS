using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Map
{
    public class ReligionMapProfile :Profile
    {
        public ReligionMapProfile()
        {
            CreateMap<Religion, ReligionDto>();
            CreateMap<ReligionDto, Religion>();
        }
    }
}
