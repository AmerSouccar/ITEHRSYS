using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages
{
    public class Language : FullAuditedAggregateRoot<Guid>
    {
        public LanguageName LanguageName { get; set; }
        public Level Writing { get; set; }
        public Level Reading { get; set; }
        public Level Speaking { get; set; }
        public Level Listening { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
