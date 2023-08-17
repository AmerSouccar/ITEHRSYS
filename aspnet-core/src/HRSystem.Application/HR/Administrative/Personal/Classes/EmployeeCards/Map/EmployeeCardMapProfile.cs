using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Map
{
    public class EmployeeCardMapProfile : Profile
    {
        public EmployeeCardMapProfile()
        {
            CreateMap<EmployeeCard, ReadEmployeeCardDto>();
            CreateMap<ReadEmployeeCardDto, EmployeeCard>();
            CreateMap<EmployeeCard, UpdateEmployeeCardDto>();
            CreateMap<UpdateEmployeeCardDto, EmployeeCard>();
        }
    }
}
