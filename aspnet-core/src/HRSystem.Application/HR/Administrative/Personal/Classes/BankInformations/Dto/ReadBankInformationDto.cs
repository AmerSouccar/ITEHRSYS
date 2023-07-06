using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto
{
    public class ReadBankInformationDto : EntityDto<Guid>
    {
        #region Bank
        public Guid BankId { get; set; }
        public ReadBankDto Bank { get; set; }
        #endregion
        public Guid EmployeeId { get; set; }
        //public ReadEmployeeDto Employee { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
