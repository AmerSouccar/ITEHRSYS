using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto
{
    public class UpdateFixedHolidayDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public DateTime Month { get; set; }
        public int NumberofDays { get; set; }
    }
}
