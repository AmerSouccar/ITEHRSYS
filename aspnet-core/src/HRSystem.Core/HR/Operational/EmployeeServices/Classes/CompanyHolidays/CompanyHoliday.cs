using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays
{
    public class CompanyHoliday : FullAuditedAggregateRoot<Guid>
    {
        public DayOfWeek DayOfWeek { get; set; }
    }
}
