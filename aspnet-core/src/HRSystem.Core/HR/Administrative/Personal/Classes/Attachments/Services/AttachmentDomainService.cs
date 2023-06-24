using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using HRSystem.Authorization.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Attachments.Services
{
    public class AttachmentDomainService : IAttachmentDomainService
    {
        private readonly IRepository<Attachment, Guid> _attachmentRepository;
        private readonly IAbpSession abpSession;
        private readonly UserManager userManager;
        private IWebHostEnvironment _environment;

        public AttachmentDomainService(IRepository<Attachment, Guid> attachmentRepository, IAbpSession abpSession, UserManager userManager, IWebHostEnvironment environment)
        {
            _attachmentRepository = attachmentRepository;
            this.abpSession = abpSession;
            this.userManager = userManager;
            _environment = environment;
        }

        public async Task Delete(Guid id)
        {
            await _attachmentRepository.DeleteAsync(id);
        }

        public async Task<Attachment> Insert(IFormFile file, string title, string description)
        {
            if (!Directory.Exists(_environment.WebRootPath + "\\Attachments\\"))
            {
                Directory.CreateDirectory(_environment.WebRootPath + "\\Attachments\\");
            }
            var DT = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Attachments\\" + DT + "_" + file.FileName))
            {
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
            }
            Attachment attachment = new Attachment()
            {
                Title = title,
                Description = description,
                FilePath = DT + "_" + file.FileName,
            };
            await _attachmentRepository.InsertAsync(attachment);
            return (attachment);
        }
    }
}
