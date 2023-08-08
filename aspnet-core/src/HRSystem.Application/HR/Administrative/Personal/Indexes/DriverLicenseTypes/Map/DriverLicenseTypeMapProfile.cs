using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Map
{
    public class DriverLicenseTypeMapProfile : Profile
    {
        public DriverLicenseTypeMapProfile()
        {
            CreateMap<DriverLicenseType, DriverLicenseTypeDto>();
            CreateMap<DriverLicenseTypeDto, DriverLicenseType>();
        }
    }
}
