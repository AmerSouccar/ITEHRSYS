﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto
{
    public class ReadMonthDto :EntityDto<Guid>
    {
        public int Year { get; set; }
        public MonthName MonthName { get; set; }
        public string Title { get; set; }
        public List<ReadMonthlyCardDto> MonthlyCards { get; set; }
        public bool isCalculated { get; set; }
    }
}
