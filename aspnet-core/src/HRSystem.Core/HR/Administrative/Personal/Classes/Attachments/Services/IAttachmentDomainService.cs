using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Services
{
    public interface IAttachmentDomainService : IDomainService
    {
        public Task<Attachment> Insert(IFormFile file,string title,string description);
        public Task Delete(Guid id);
    }
}
