using HRSystem.HR.Administrative.Personal.Indexes.Religions.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Service
{
    public class ReligionAppService : HRSystemAppServiceBase, IReligionAppService
    {
        private readonly IReligionDomainService _religionDomainService;

        public ReligionAppService(IReligionDomainService religionDomainService)
        {
            _religionDomainService = religionDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
           await _religionDomainService.DeleteAsync(id);
        }

        public async Task<List<ReligionDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<ReligionDto>>(await _religionDomainService.GetAllAsync());
        }

        public async Task<ReligionDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReligionDto>(await _religionDomainService.GetbyId(id));
        }

        public async Task<ReligionDto> InsertAsync(ReligionDto religion)
        {
           return ObjectMapper.Map<ReligionDto>(await _religionDomainService.InsertAsync(ObjectMapper.Map<Religion> (religion)));
        }

        public async Task<ReligionDto> UpdateAsync(ReligionDto religion)
        {
            return ObjectMapper.Map<ReligionDto>(await _religionDomainService.UpdateAsync(ObjectMapper.Map<Religion>(religion)));

        }
    }
}
