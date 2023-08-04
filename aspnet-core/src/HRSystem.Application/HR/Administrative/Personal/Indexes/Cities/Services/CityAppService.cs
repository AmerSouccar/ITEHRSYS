using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Cities.Services
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

        public PagedResultDto<CityDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var cities = _cityDomainService.GetAll();
            int total = cities.Count();
            cities = cities.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<CityDto>>(cities.ToList());
            return new PagedResultDto<CityDto>(total, list);
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
