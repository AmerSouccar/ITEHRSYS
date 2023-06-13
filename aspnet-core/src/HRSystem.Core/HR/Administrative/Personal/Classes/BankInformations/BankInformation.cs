using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations
{
    public class BankInformation : FullAuditedAggregateRoot<Guid>
    {
        #region Bank
        public Guid BankId { get; set; }
        public Bank Bank { get; set; }
        #endregion
        //add employee card information
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
