using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Services
{
    public class CertificateDomainService : ICertificateDomainService
    {
        private readonly IRepository<Certificate, Guid> _certificateRepository;

        public CertificateDomainService(IRepository<Certificate, Guid> certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        public async Task Delete(Guid id)
        {
            await _certificateRepository.DeleteAsync(id);
        }

        public async Task<List<Certificate>> GetAll()
        {
            return _certificateRepository.GetAllIncluding(x => x.PlaceofIssuance,x => x.Attachments).ToList();
        }

        public async Task<Certificate> GetbyId(Guid id)
        {
            return _certificateRepository.GetAllIncluding(x => x.PlaceofIssuance, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Certificate> Insert(Certificate certificate)
        {
            return await _certificateRepository.InsertAsync(certificate);
        }

        public async Task<Certificate> Update(Certificate certificate)
        {
            return await _certificateRepository.UpdateAsync(certificate);
        }
    }
}
