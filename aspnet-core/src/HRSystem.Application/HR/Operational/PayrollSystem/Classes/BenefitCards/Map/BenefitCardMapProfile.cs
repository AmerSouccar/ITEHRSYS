using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Map
{
    public class BenefitCardMapProfile : Profile
    {
        public BenefitCardMapProfile()
        {
            CreateMap<BenefitCard, ReadBenefitCardDto>();
            CreateMap<ReadBenefitCardDto, BenefitCard>();
            CreateMap<BenefitCard, InsertBenefitCardDto>();
            CreateMap<InsertBenefitCardDto, BenefitCard>();
            CreateMap<BenefitCard, UpdateBenefitCardDto>();
            CreateMap<UpdateBenefitCardDto, BenefitCard>();
        }
    }
}
