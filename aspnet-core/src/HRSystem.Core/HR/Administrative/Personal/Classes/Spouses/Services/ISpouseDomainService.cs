using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Passports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Services
{
    public interface ISpouseDomainService :IDomainService
    {
        public Task<List<Spouse>> GetAll();
        public Task<Spouse> GetbyId(Guid id);
        public Task<Spouse> Insert(Spouse spouse);
        public Task<Spouse> Update(Spouse spouse);
        public Task Delete(Guid id);
    }
}
