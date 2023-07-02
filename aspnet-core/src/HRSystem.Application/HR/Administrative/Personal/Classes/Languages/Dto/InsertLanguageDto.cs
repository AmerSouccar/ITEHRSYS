using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Dto
{
    public class InsertLanguageDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Guid LanguageNameId { get; set; }
        public Guid WritingId { get; set; }
        public Guid ReadingId { get; set; }
        public Guid SpeakingId { get; set; }
        public Guid ListeningId { get; set; }
    }
}
