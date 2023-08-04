using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Services
{
    public interface ICustodieDomainService :IDomainService
    {
        public IQueryable<Custodie> GetAll();
        public Task<Custodie> GetbyId(Guid id);
        public Task<Custodie> Insert(Custodie custodie);
        public Task<Custodie> Update(Custodie custodie);
        public Task Delete(Guid id);
    }
}
