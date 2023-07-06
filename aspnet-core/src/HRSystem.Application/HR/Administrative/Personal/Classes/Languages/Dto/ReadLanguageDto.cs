using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Dto
{
    public class ReadLanguageDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }

        public Guid LanguageNameId { get; set; }
        public LanguageNameDto LanguageName { get; set; }
        public Guid WritingId { get; set; }
        public LevelDto Writing { get; set; }
        public Guid ReadingId { get; set; }
        public LevelDto Reading { get; set; }
        public Guid SpeakingId { get; set; }
        public LevelDto Speaking { get; set; }
        public Guid ListeningId { get; set; }
        public LevelDto Listening { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }

    }
}
