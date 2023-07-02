using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Passports.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Map
{
    public class PassportMapProfile : Profile
    {
        public PassportMapProfile()
        {
            CreateMap<Passport, ReadPassportDto>();
            CreateMap<ReadPassportDto, Passport>();
            CreateMap<Passport, InsertPassportDto>();
            CreateMap<InsertPassportDto, Passport>();
            CreateMap<Passport, UpdatePassportDto>();
            CreateMap<UpdatePassportDto, Passport>();
        }
    }
}
