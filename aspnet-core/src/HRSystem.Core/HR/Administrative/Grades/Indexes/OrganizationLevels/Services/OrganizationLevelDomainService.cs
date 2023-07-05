using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Services
{
    public class OrganizationLevelDomainService : IOrganizationLevelDomainService
    {
        private readonly IRepository<OrganizationLevel,Guid> _organizationLevelRepository;

        public OrganizationLevelDomainService(IRepository<OrganizationLevel, Guid> organizationLevelRepository)
        {
            _organizationLevelRepository = organizationLevelRepository;
        }

        public async Task Delete(Guid id)
        {
           await _organizationLevelRepository.DeleteAsync(id);
        }

        public async Task<List<OrganizationLevel>> GetAll()
        {
            return await _organizationLevelRepository.GetAllListAsync();
        }

        public async Task<OrganizationLevel> GetbyId(Guid id)
        {
            return await _organizationLevelRepository.GetAsync(id);
        }

        public async Task<OrganizationLevel> Insert(OrganizationLevel organizationLevel)
        {
            return await _organizationLevelRepository.InsertAsync(organizationLevel);
        }

        public async Task<OrganizationLevel> Update(OrganizationLevel organizationLevel)
        {
            return await _organizationLevelRepository.UpdateAsync(organizationLevel);
        }
    }
}
