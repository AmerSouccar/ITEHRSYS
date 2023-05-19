using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates
{
    public class Certificate : FullAuditedAggregateRoot<Guid>
    {
        public string Type { get; set; }
        public City PlaceofIssuance { get; set; }
        public DateTime DateofIssuance { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
