using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Services;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Services
{
    public class DependentAppService : HRSystemAppServiceBase, IDependentAppService
    {
        private readonly IDependentDomainService _dependentDomainService;

        public DependentAppService(IDependentDomainService dependentDomainService)
        {
            _dependentDomainService = dependentDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _dependentDomainService.Delete(id);
        }

        public PagedResultDto<ReadDependentDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var dependants = _dependentDomainService.GetAll();
            int total = dependants.Count();
            dependants = dependants.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadDependentDto>>(dependants.ToList());
            return new PagedResultDto<ReadDependentDto>(total, list);
        }

        public async Task<ReadDependentDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadDependentDto>(await _dependentDomainService.GetbyId(id));
        }

        public async Task<InsertDependentDto> Insert(InsertDependentDto dependent)
        {
           return ObjectMapper.Map<InsertDependentDto>(await _dependentDomainService.Insert(ObjectMapper.Map<Dependent>(dependent)));
        }

        public async Task<UpdateDependentDto> Update(UpdateDependentDto dependent)
        {
            return ObjectMapper.Map<UpdateDependentDto>(await _dependentDomainService.Update(ObjectMapper.Map<Dependent>(dependent)));

        }
    }
}
