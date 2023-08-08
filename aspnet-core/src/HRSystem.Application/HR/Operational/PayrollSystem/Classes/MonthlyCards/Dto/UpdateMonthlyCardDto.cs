using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto
{
    public class UpdateMonthlyCardDto : EntityDto<Guid>
    {
        public Guid EmployeeCardId { get; set; }
        public double Salary { get; set; }
        public bool Calculated { get; set; }
        public double WorkDays { get; set; }
        public double TotalDeductions { get; set; }
        public double TotalBenefits { get; set; }
        public double FinalSalary { get; set; }
    }
}
