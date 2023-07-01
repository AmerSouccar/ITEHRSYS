using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Services
{
    public class CertificateAppService : HRSystemAppServiceBase, ICertificateAppService
    {
        private readonly ICertificateDomainService _certificateDomainService;

        public CertificateAppService(ICertificateDomainService certificateDomainService)
        {
            _certificateDomainService = certificateDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _certificateDomainService.Delete(id);
        }

        public async Task<List<ReadCertificateDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadCertificateDto>>(await _certificateDomainService.GetAll());
        }

        public async Task<ReadCertificateDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadCertificateDto>(await _certificateDomainService.GetbyId(id));
        }

        public async Task<InsertCertificateDto> Insert(InsertCertificateDto certificate)
        {
            return ObjectMapper.Map<InsertCertificateDto>(await _certificateDomainService.Insert(ObjectMapper.Map<Certificate>(certificate)));
        }

        public async Task<UpdateCertificateDto> Update(UpdateCertificateDto certificate)
        {
            return ObjectMapper.Map<UpdateCertificateDto>(await _certificateDomainService.Insert(ObjectMapper.Map<Certificate>(certificate)));
        }
    }
}
