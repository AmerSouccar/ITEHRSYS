using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto
{
    public class UpdateMonthDto :EntityDto<Guid>
    {
        public int Year { get; set; }
        public int MonthName { get; set; }
        public string Title { get; set; }
        public bool isCalculated { get; set; }
    }
}
