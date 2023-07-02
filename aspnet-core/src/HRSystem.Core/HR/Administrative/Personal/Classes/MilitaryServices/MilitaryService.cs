using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices
{
    public class MilitaryService : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public MilitaryStatus MilitaryStatus { get; set; }
        public bool? IsPermanentExemption { get; set; }
        public string ExemptionReason { get; set; }
        public DateTime? ExemptionDate { get; set; }
        public string DelayReason { get; set; }
        public DateTime? DelayDate { get; set; }
        public string MilitaryServiceNo { get; set; }
        public DateTime? MilitaryServiceDocIssueDate { get; set; }
        public string Granter { get; set; }
        public int? Years { get; set; }
        public int? Months { get; set; }
        public int? Days { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public DateTime? HoldDate { get; set; }
        public DateTime? ReserveStartDate { get; set; }
        public string Notes { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
