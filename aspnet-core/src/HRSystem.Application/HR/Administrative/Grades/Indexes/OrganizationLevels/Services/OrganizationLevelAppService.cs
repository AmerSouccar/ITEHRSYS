using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.Grades;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadOrganizationLevelDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var organizationLevels = _organizationLevelDomainService.GetAll();
            int total = organizationLevels.Count();
            organizationLevels = organizationLevels.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadOrganizationLevelDto>>(organizationLevels.ToList());
            return new PagedResultDto<ReadOrganizationLevelDto>(total, list);
        }

        public async Task<ReadOrganizationLevelDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadOrganizationLevelDto>(await _organizationLevelDomainService.GetbyId(id));
        }

        public async Task<UpdateOrganizationLevelDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateOrganizationLevelDto>(await _organizationLevelDomainService.GetbyId(id));
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
