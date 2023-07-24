using AutoMapper;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Map
{
    public class FinancialCardMapProfile :Profile
    {
        public FinancialCardMapProfile()
        {
            CreateMap<FinancialCard, ReadFinancialCardDto>();
            CreateMap<ReadFinancialCardDto, FinancialCard>();
            CreateMap<FinancialCard, InsertFinancialCardDto>();
            CreateMap<InsertFinancialCardDto, FinancialCard>();
            CreateMap<FinancialCard, UpdateFinancialCardDto>();
            CreateMap<UpdateFinancialCardDto, FinancialCard>();
        }
    }
}
