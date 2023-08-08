using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadCertificateDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var certificates = _certificateDomainService.GetAll();
            int total = certificates.Count();
            certificates = certificates.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadCertificateDto>>(certificates.ToList());
            return new PagedResultDto<ReadCertificateDto>(total, list);
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
