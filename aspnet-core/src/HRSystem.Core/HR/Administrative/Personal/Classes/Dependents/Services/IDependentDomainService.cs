using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Custodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Services
{
    public interface IDependentDomainService :IDomainService
    {
        public Task<List<Dependent>> GetAll();
        public Task<Dependent> GetbyId(Guid id);
        public Task<Dependent> Insert(Dependent dependent);
        public Task<Dependent> Update(Dependent dependent);
        public Task Delete(Guid id);
    }
}
