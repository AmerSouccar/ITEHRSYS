using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Map
{
    public class DriverLicenseMapProfile : Profile
    {
        public DriverLicenseMapProfile()
        {
            CreateMap<DriverLicense, ReadDriverLicenseDto>();
            CreateMap<ReadDriverLicenseDto, DriverLicense>();
            CreateMap<DriverLicense, InsertDriverLicenseDto>();
            CreateMap<InsertDriverLicenseDto, DriverLicense>();
            CreateMap<DriverLicense, UpdateDriverLicenseDto>();
            CreateMap<UpdateDriverLicenseDto, DriverLicense>();
        }
    }
}
