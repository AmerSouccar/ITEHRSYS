using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards
{
    public class FinancialCard : FullAuditedAggregateRoot<Guid>
    {
        public Employee Employee { get; set; }
        public double Salary { get; set; }
    }
}
