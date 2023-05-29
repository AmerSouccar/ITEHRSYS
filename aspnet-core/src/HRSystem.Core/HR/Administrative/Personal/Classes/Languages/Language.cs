using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages
{
    public class Language : FullAuditedAggregateRoot<Guid>
    {
        #region LanguageName
        [ForeignKey("LanguageName")]
        public Guid LanguageNameId { get; set; }
        public LanguageName LanguageName { get; set; }
        #endregion
        #region Writing
        [ForeignKey("Writing")]
        public Guid WritingId { get; set; }
        public Level Writing { get; set; }
        #endregion
        #region Reading
        [ForeignKey("Reading")]
        public Guid ReadingId { get; set; }
        public Level Reading { get; set; }
        #endregion
        #region Speaking
        [ForeignKey("Speaking")]
        public Guid SpeakingId { get; set; }
        public Level Speaking { get; set; }
        #endregion
        #region Listening
        [ForeignKey("Listening")]
        public Guid ListeningId { get; set; }
        public Level Listening { get; set; }
        #endregion
        public List<Attachment> Attachments { get; set; }
    }
}
