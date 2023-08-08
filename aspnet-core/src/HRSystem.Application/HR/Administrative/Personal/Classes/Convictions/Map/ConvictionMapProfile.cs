using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Map
{
    public class ConvictionMapProfile : Profile
    {
        public ConvictionMapProfile()
        {
            CreateMap<Conviction, ReadConvictionDto>();
            CreateMap<ReadConvictionDto, Conviction>();
            CreateMap<Conviction, InsertConvictionDto>();
            CreateMap<InsertConvictionDto, Conviction>();
            CreateMap<Conviction, UpdateConvictionDto>();
            CreateMap<UpdateConvictionDto, Conviction>();
        }
    }
}
