using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Map
{
    public class SpouseMapProfile : Profile
    {
        public SpouseMapProfile()
        {
            CreateMap<Spouse, ReadSpouseDto>();
            CreateMap<ReadSpouseDto, Spouse>();
            CreateMap<Spouse, InsertSpouseDto>();
            CreateMap<InsertSpouseDto, Spouse>();
            CreateMap<Spouse, UpdateSpouseDto>();
            CreateMap<UpdateSpouseDto, Spouse>();
        }
    }
}
