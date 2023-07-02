using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations
{
    public class BankInformation : FullAuditedAggregateRoot<Guid>
    {
        #region Bank
        [ForeignKey("Bank")]
        public Guid BankId { get; set; }
        public Bank Bank { get; set; }
        #endregion
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
