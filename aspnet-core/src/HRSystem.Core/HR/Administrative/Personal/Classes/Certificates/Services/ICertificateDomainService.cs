using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Services
{
    public interface ICertificateDomainService : IDomainService
    {
        public Task<List<Certificate>> GetAll();
        public Task<Certificate> GetbyId(Guid id);
        public Task<Certificate> Insert(Certificate certificate);
        public Task<Certificate> Update(Certificate certificate);
        public Task Delete(Guid id);
    }
}
