using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto
{
    public class UpdateFinancialCardDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public double Salary { get; set; }
    }
}
