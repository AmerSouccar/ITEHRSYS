using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions
{
    public class Conviction : FullAuditedAggregateRoot<Guid>
    {
        public string Number { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool isConvicted { get; set; }
        public string Notes { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
