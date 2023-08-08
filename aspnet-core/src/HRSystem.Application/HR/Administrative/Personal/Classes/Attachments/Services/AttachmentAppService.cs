using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Services
{
    public class AttachmentAppService : HRSystemAppServiceBase, IAttachmentAppService
    {
        private readonly IAttachmentDomainService _attachmentDomainService;

        public AttachmentAppService(IAttachmentDomainService attachmentDomainService)
        {
            _attachmentDomainService = attachmentDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _attachmentDomainService.Delete(id);
        }

        public async Task<ReadAttachmentDto> Insert(IFormFile file, string title, string description)
        {
            return ObjectMapper.Map<ReadAttachmentDto>(await _attachmentDomainService.Insert(file, title, description));
        }
    }
}
