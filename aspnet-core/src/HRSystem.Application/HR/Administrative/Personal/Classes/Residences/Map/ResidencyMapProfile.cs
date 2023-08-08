using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Map
{
    public class ResidencyMapProfile : Profile
    {
        public ResidencyMapProfile()
        {
            CreateMap<Residency, ReadResidencyDto>();
            CreateMap<ReadResidencyDto, Residency>();
            CreateMap<Residency, InsertResidencyDto>();
            CreateMap<InsertResidencyDto, Residency>();
            CreateMap<Residency, UpdateResidencyDto>();
            CreateMap<UpdateResidencyDto, Residency>();
        }
    }
}
