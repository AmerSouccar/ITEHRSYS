using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Experiences
{
    public class Experience :FullAuditedAggregateRoot<Guid>
    {
        public string JobTitle { get; set; }
        public string Industry { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyLocation { get; set; }
        public string? CompanyWebSite { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate  { get; set; }
        public string? LeaveReason { get; set; }
        public string? Notes { get; set; }
        public string? ReferenceFullName { get; set; }
        public string? ReferenceJobTitle { get; set; }
        public string? ReferenceContact { get; set; }
        public string? ReferenceEmail { get; set; }
        public List<Attachment> Attachments { get; set; }


    }
}
