using HRSystem.HR.Administrative.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Indexes.Cities.Services
{
    public class CityAppService : HRSystemAppServiceBase, ICityAppService
    {
        private readonly ICityDomainService _cityDomainService;

        public CityAppService(ICityDomainService cityDomainService)
        {
            _cityDomainService = cityDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _cityDomainService.DeleteAsync(id);
        }

        public async Task<CityDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<CityDto>(await _cityDomainService.GetbyId(id));
        }

        public async Task<List<CityDto>> GetCitiesAsync()
        {
            return ObjectMapper.Map<List<CityDto>>(await _cityDomainService.GetCitiesAsync());
        }

        public async Task<CityDto> InsertAsync(CityDto city)
        {
            return ObjectMapper.Map<CityDto>(await _cityDomainService.InsertAsync(ObjectMapper.Map<City>(city)));
        }

        public async Task<CityDto> UpdateAsync(CityDto city)
        {
            return ObjectMapper.Map<CityDto>(await _cityDomainService.UpdateAsync(ObjectMapper.Map<City>(city)));
        }
    }
}
