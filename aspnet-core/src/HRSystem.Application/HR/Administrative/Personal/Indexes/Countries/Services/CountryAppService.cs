﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Countries.Services
{
    public class CountryAppService : HRSystemAppServiceBase, ICountryAppService
    {
        private readonly ICountryDomainService _countryDomainService;

        public CountryAppService(ICountryDomainService countryDomainService)
        {
            this._countryDomainService = countryDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
           await _countryDomainService.DeleteAsync(id);
        }

        public PagedResultDto<CountryDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var countries = _countryDomainService.GetAll();
            int total = countries.Count();
            countries = countries.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<CountryDto>>(countries.ToList());
            return new PagedResultDto<CountryDto>(total, list);
        }

        public async Task<CountryDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<CountryDto>(await _countryDomainService.GetbyId(id));
        }

        public async Task<CountryDto> InsertAsync(CountryDto country)
        {
            return ObjectMapper.Map<CountryDto>(await _countryDomainService.InsertAsync(ObjectMapper.Map<Country>(country)));
        }

        public async Task<CountryDto> UpdateAsync(CountryDto country)
        {
            return ObjectMapper.Map<CountryDto>(await _countryDomainService.UpdateAsync(ObjectMapper.Map<Country>(country)));
        }
    }
}
