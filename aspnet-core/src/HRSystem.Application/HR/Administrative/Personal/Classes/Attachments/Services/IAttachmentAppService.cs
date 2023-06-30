using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Services
{
    public interface IAttachmentAppService : IApplicationService
    {
        public Task<ReadAttachmentDto> Insert(IFormFile file, string title, string description);
        public Task Delete(Guid id);
    }
}
