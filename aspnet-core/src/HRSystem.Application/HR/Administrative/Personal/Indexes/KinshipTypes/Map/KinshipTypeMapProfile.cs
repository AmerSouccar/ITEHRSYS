using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Map
{
    public class KinshipTypeMapProfile : Profile
    {
        public KinshipTypeMapProfile()
        {
            CreateMap<KinshipType, KinshipTypeDto>();
            CreateMap<KinshipTypeDto, KinshipType>();
        }
    }
}
