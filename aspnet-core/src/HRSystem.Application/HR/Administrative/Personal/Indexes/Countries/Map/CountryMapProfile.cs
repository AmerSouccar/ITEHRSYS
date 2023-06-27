using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Countries.Map
{
    public class CountryMapProfile : Profile
    {
        public CountryMapProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
        }
    }
}
