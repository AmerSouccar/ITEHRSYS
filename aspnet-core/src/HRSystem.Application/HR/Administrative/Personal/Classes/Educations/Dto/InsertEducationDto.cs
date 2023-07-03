using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Dto
{
    public class InsertEducationDto :EntityDto<Guid>
    {
        public Guid TypeId { get; set; }
        public Guid MajorId { get; set; }
        public Guid UniversityId { get; set; }
        public Guid RankId { get; set; }
        public Guid ScoreTypeId { get; set; }
        public Guid ScoreId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? DateofIssuance { get; set; }
        public Guid CountryId { get; set; }
        public string AmendmentDocumentNo { get; set; }
        public DateTime? AmendmentDocumentDate { get; set; }
        public string Comments { get; set; }
    }
}
