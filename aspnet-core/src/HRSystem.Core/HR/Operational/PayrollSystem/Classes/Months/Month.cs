using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months
{
    public class Month : FullAuditedAggregateRoot<Guid>
    {
        public int Year { get; set; }
        public MonthName MonthName { get; set; }
        public string Title { get; set; }
        public List<MonthlyCard> MonthlyCards { get; set; }
        public bool isCalculated { get; set; }
    }
}
