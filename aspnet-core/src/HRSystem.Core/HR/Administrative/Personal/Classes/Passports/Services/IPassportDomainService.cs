using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Services
{
    public interface IPassportDomainService :IDomainService
    {
        public IQueryable<Passport> GetAll();
        public Task<Passport> GetbyId(Guid id);
        public Task<Passport> Insert(Passport passport);
        public Task<Passport> Update(Passport passport);
        public Task Delete(Guid id);
    }
}
