using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Services
{
    public interface IOrganizationLevelDomainService : IDomainService
    {
        public IQueryable<OrganizationLevel> GetAll();
        public Task<OrganizationLevel> GetbyId(Guid id);
        public Task<OrganizationLevel> Insert(OrganizationLevel organizationLevel);
        public Task<OrganizationLevel> Update(OrganizationLevel organizationLevel);
        public Task Delete(Guid id);
    }
}
