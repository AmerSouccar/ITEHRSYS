using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto
{
    public class InsertFinancialCardDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public double Salary { get; set; }
    }
}
