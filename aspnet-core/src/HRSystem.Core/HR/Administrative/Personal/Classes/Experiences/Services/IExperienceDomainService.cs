using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Services
{
    public interface IExperienceDomainService :IDomainService
    {
        public Task<List<Experience>> GetAll();
        public Task<Experience> GetbyId(Guid id);
        public Task<Experience> Insert(Experience experience);
        public Task<Experience> Update(Experience experience);
        public Task Delete(Guid id);
    }
}
