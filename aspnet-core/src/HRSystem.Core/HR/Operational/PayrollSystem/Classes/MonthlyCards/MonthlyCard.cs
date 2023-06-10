using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards
{
    public class MonthlyCard : FullAuditedAggregateRoot<Guid>
    {
        public EmployeeCard EmployeeCard { get; set; }
        public double Salary { get; set; }
        public bool Calculated { get; set; }
        public double WorkDays { get; set; }
        public double TotalDeductions { get; set; }
        public double TotalBenefits { get; set; }
        public double FinalSalary { get; set; }
        public List<BenefitCard> BenefitCards { get; set; }
        public List<DeductionCard> DeductionCards { get; set; }
    }
}
