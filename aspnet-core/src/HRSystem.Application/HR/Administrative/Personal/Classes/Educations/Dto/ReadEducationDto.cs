using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Dto
{
    public class ReadEducationDto :EntityDto<Guid>
    {
        public Guid TypeId { get; set; }
        public EducationTypeDto Type { get; set; }
        public Guid MajorId { get; set; }
        public EducationMajorDto Major { get; set; }
        public Guid UniversityId { get; set; }
        public UniversityDto University { get; set; }
        public Guid RankId { get; set; }
        public RankDto Rank { get; set; }
        public Guid ScoreTypeId { get; set; }
        public ScoreTypeDto ScoreType { get; set; }
        public Guid ScoreId { get; set; }
        public ScoreDto Score { get; set; }
        public Guid EmployeeId { get; set; }
        //public ReadEmployeeDto Employee { get; set; }
        public DateTime? DateofIssuance { get; set; }
        public Guid CountryId { get; set; }
        public CountryDto Country { get; set; }
        public string AmendmentDocumentNo { get; set; }
        public DateTime? AmendmentDocumentDate { get; set; }
        public string Comments { get; set; }

        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
