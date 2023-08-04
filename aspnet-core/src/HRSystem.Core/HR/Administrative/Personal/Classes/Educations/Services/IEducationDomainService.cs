using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Services
{
    public interface IEducationDomainService :IDomainService
    {
        public IQueryable<Education> GetAll();
        public Task<Education> GetbyId(Guid id);
        public Task<Education> Insert(Education education);
        public Task<Education> Update(Education education);
        public Task Delete(Guid id);
    }
}
