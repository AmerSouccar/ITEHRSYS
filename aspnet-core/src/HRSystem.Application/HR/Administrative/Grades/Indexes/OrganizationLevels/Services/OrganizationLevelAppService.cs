using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Services
{
    public class OrganizationLevelAppService : HRSystemAppServiceBase, IOrganizationLevelAppService
    {
        private readonly IOrganizationLevelDomainService _organizationLevelDomainService;

        public OrganizationLevelAppService(IOrganizationLevelDomainService organizationLevelDomainService)
        {
            _organizationLevelDomainService = organizationLevelDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _organizationLevelDomainService.Delete(id);
        }

        public async Task<List<ReadOrganizationLevelDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadOrganizationLevelDto>>(await _organizationLevelDomainService.GetAll());
        }

        public async Task<ReadOrganizationLevelDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadOrganizationLevelDto>(await _organizationLevelDomainService.GetbyId(id));
        }

        public async Task<InsertOrganizationLevelDto> Insert(InsertOrganizationLevelDto organizationLevel)
        {
           return ObjectMapper.Map<InsertOrganizationLevelDto>(await _organizationLevelDomainService.Insert(ObjectMapper.Map<OrganizationLevel>(organizationLevel)));
        }

        public async Task<UpdateOrganizationLevelDto> Update(UpdateOrganizationLevelDto organizationLevel)
        {
            return ObjectMapper.Map<UpdateOrganizationLevelDto>(await _organizationLevelDomainService.Update(ObjectMapper.Map<OrganizationLevel>(organizationLevel)));

        }
    }
}
