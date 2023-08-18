using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto
{
    public class ReadFixedHolidayDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public int NumberofDays { get; set; }
    }
}
