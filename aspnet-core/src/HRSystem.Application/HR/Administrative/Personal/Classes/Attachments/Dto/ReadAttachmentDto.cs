using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto
{
    public class ReadAttachmentDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
