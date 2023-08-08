using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations
{
    public class Education : FullAuditedAggregateRoot<Guid>
    {
        #region Type
        [ForeignKey("Type")]
        public Guid TypeId { get; set; }
        public EducationType Type { get; set; }
        #endregion
        #region Major
        [ForeignKey("Major")]
        public Guid MajorId { get; set; }
        public EducationMajor Major { get; set; }
        #endregion
        #region University
        [ForeignKey("University")]
        public Guid UniversityId { get; set; }
        public University University { get; set; }
        #endregion
        #region Rank
        [ForeignKey("Rank")]
        public Guid RankId { get; set; }
        public Rank Rank { get; set; }
        #endregion
        #region ScoreType
        [ForeignKey("ScoreType")]
        public Guid ScoreTypeId { get; set; }
        public ScoreType ScoreType { get; set; }
        #endregion
        #region Score
        [ForeignKey("Score")]
        public Guid ScoreId { get; set; }
        public Score Score { get; set; }
        #endregion
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public DateTime? DateofIssuance { get; set; }
        #region Country
        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        #endregion
        public string AmendmentDocumentNo { get; set; }
        public DateTime? AmendmentDocumentDate { get; set; }
        public string Comments { get; set; }

        public List<Attachment> Attachments { get; set; }

    }
}
