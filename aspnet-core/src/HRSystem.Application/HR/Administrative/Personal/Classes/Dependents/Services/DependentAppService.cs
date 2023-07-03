using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
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

        public async Task<List<ReadDependentDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadDependentDto>>(await _dependentDomainService.GetAll());
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
