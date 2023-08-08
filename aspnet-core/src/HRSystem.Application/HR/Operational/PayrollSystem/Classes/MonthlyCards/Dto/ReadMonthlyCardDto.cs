using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto
{
    public class ReadMonthlyCardDto :EntityDto<Guid>
    {
        public Guid EmployeeCardId { get; set; }
        //public ReadEmployeeCardDto EmployeeCard { get; set; }
        public double Salary { get; set; }
        public bool Calculated { get; set; }
        public double WorkDays { get; set; }
        public double TotalDeductions { get; set; }
        public double TotalBenefits { get; set; }
        public double FinalSalary { get; set; }
        public List<ReadBenefitCardDto> BenefitCards { get; set; }
        public List<ReadDeductionCardDto> DeductionCards { get; set; }
    }
}
