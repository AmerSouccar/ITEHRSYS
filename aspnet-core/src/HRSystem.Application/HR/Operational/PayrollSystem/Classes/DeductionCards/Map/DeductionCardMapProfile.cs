using AutoMapper;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Dto;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Map
{
    public class DeductionCardMapProfile :Profile
    {
        public DeductionCardMapProfile()
        {
            CreateMap<DeductionCard, ReadDeductionCardDto>();
            CreateMap<ReadDeductionCardDto, DeductionCard>();
            CreateMap<DeductionCard, InsertDeductionCardDto>();
            CreateMap<InsertDeductionCardDto, DeductionCard>();
            CreateMap<DeductionCard, UpdateDeductionCardDto>();
            CreateMap<UpdateDeductionCardDto, DeductionCard>();
        }
    }
}
