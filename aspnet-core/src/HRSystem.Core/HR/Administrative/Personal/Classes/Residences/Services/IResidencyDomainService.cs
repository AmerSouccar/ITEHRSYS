using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Passports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Services
{
    public interface IResidencyDomainService : IDomainService
    {
        public Task<List<Residency>> GetAll();
        public Task<Residency> GetbyId(Guid id);
        public Task<Residency> Insert(Residency Residency);
        public Task<Residency> Update(Residency Residency);
        public Task Delete(Guid id);
    }
}
