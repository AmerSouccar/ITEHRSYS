using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Map
{
    public class CustodieMapProfile : Profile
    {
        public CustodieMapProfile()
        {
            CreateMap<Custodie, ReadCustodieDto>();
            CreateMap<ReadCustodieDto, Custodie>();
            CreateMap<Custodie, InsertCustodieDto>();
            CreateMap<InsertCustodieDto, Custodie>();
            CreateMap<Custodie, UpdateCustodieDto>();
            CreateMap<UpdateCustodieDto, Custodie>();
        }
    }
}
