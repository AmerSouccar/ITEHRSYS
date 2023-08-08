using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto
{
    public class InsertBankInformationDto : EntityDto<Guid>
    {
        public Guid BankId { get; set; }
        public Guid EmployeeId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
