using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills
{
    public class Skill : FullAuditedAggregateRoot<Guid>
    {
        public string SkillName { get; set; }
        #region Level
        [ForeignKey("Level")]
        public Guid LevelId { get; set; }
        public Level Level { get; set; }
        #endregion
        public string Description { get; set; }
        public string Comments { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
