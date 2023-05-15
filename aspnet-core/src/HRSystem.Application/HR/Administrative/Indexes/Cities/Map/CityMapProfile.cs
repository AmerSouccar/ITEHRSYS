using AutoMapper;
using HRSystem.HR.Administrative.Indexes.Cities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Indexes.Cities.Map
{
    public class CityMapProfile : Profile
    {
        public CityMapProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();
        }
    }
}
