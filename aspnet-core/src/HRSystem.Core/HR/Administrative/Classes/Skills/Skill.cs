using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Indexes.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Skills
{
    public class Skill : FullAuditedAggregateRoot<Guid>
    {
        public string SkillName { get; set; }
        public Level Level { get; set; }
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
