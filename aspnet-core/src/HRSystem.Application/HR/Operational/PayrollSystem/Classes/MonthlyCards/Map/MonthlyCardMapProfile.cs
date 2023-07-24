using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Map
{
    public class MonthlyCardMapProfile :Profile
    {
        public MonthlyCardMapProfile()
        {
            CreateMap<MonthlyCard, ReadMonthlyCardDto>();
            CreateMap<ReadMonthlyCardDto, MonthlyCard>();
            CreateMap<MonthlyCard, InsertMonthlyCardDto>();
            CreateMap<InsertMonthlyCardDto, MonthlyCard>();
            CreateMap<MonthlyCard, UpdateMonthlyCardDto>();
            CreateMap<UpdateMonthlyCardDto, MonthlyCard>();
        }
    }
}
