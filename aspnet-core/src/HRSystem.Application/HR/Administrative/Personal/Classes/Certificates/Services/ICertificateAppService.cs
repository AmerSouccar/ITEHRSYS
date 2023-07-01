using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Services
{
    public interface ICertificateAppService : IApplicationService
    {
        public Task<List<ReadCertificateDto>> GetAll();
        public Task<ReadCertificateDto> GetbyId(Guid id);
        public Task<InsertCertificateDto> Insert(InsertCertificateDto certificate);
        public Task<UpdateCertificateDto> Update(UpdateCertificateDto certificate);
        public Task Delete(Guid id);
    }
}
