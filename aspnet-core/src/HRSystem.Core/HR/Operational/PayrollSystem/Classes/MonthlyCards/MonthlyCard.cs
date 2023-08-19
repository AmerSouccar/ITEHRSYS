using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards
{
    public class MonthlyCard : FullAuditedAggregateRoot<Guid>
    {
        #region EmployeeCard
        [ForeignKey("EmployeeCard")]
        public Guid EmployeeCardId { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        #endregion
        public double Salary { get; set; }
        public bool Calculated { get; set; }
        public double WorkDays { get; set; }
        public double TotalDeductions { get; set; }
        public double TotalBenefits { get; set; }
        public double FinalSalary { get; set; }
        [ForeignKey("Month")]
        public Guid MonthId { get; set; }
        public Month Month { get; set; }
        public List<BenefitCard> BenefitCards { get; set; }
        public List<DeductionCard> DeductionCards { get; set; }
    }
}
