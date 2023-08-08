using AutoMapper;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Map
{
    public class MonthMapProfile :Profile
    {
        public MonthMapProfile()
        {
            CreateMap<Month, ReadMonthDto>();
            CreateMap<ReadMonthDto, Month>();
            CreateMap<Month, InsertMonthDto>();
            CreateMap<InsertMonthDto, Month>();
            CreateMap<Month, UpdateMonthDto>();
            CreateMap<UpdateMonthDto, Month>();
        }
    }
}
