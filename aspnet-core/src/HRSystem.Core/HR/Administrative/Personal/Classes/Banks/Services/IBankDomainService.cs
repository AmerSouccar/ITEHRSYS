using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Services
{
    public interface IBankDomainService : IDomainService
    {
        public IQueryable<Bank> GetAll();
        public Task<Bank> GetbyId(Guid id);
        public Task<Bank> Insert(Bank bank);
        public Task<Bank> Update(Bank bank);
        public Task Delete(Guid id);
    }
}
