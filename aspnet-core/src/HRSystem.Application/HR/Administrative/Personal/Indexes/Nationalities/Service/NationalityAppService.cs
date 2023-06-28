using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Service
{
    public class NationalityAppService : HRSystemAppServiceBase, INationalityAppService
    {
        private readonly INationalityDomainService _nationalityDomainService;

        public NationalityAppService(INationalityDomainService nationalityDomainService)
        {
            _nationalityDomainService = nationalityDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _nationalityDomainService.DeleteAsync(id);
        }

        public async Task<List<NationalityDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<NationalityDto>>(await _nationalityDomainService.GetAllAsync());
        }

        public async Task<NationalityDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.GetbyId(id));
        }

        public async Task<NationalityDto> InsertAsync(NationalityDto nationality)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.InsertAsync(ObjectMapper.Map<Nationality>(nationality)));
        }

        public async Task<NationalityDto> UpdateAsync(NationalityDto nationality)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.UpdateAsync(ObjectMapper.Map<Nationality>(nationality)));

        }
    }
}
