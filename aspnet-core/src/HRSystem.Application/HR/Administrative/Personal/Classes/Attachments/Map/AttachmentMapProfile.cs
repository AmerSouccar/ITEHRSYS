using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Map
{
    public class AttachmentMapProfile : Profile
    {
        public AttachmentMapProfile()
        {
            CreateMap<Attachment, ReadAttachmentDto>();
            CreateMap<ReadAttachmentDto, Attachment>();
        }
    }
}
