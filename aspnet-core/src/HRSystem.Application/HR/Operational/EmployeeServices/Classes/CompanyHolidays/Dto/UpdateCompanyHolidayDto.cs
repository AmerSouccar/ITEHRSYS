using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto
{
    public class UpdateCompanyHolidayDto :EntityDto<Guid>
    {
        public DayOfWeek DayOfWeek { get; set; }

    }
}
