using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Indexes.Countries;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.EducationMajors;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.EducationTypes;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Ranks;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Scores;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.ScoreTypes;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Educations
{
    public class Education : FullAuditedAggregateRoot<Guid>
    {
        public EducationType Type { get; set; }
        public EducationMajor Major { get; set; }
        public University? University { get; set; }
        public Rank? Rank { get; set; }
        public ScoreType? ScoreType { get; set; }
        public Score? Score { get; set; }
        public DateTime? DateofIssuance { get; set; }
        public Country? Country { get; set; }
        public string? AmendmentDocumentNo { get; set; }
        public DateTime? AmendmentDocumentDate { get; set; }
        public string? Comments { get; set; }

        public List<Attachment> Attachments { get; set; }

    }
}
