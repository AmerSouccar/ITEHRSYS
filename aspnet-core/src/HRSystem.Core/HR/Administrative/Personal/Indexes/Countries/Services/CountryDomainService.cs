using Abp.Domain.Repositories;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Countries.Services
{
    public class CountryDomainService : ICountryDomainService
    {
        private readonly IRepository<Country, Guid> _countries;

        public CountryDomainService(IRepository<Country, Guid> countries)
        {
            _countries = countries;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _countries.DeleteAsync(id);
        }

        public async Task<Country> GetbyId(Guid id)
        {
            return await _countries.GetAsync(id);
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _countries.GetAllListAsync();
        }

        public async Task<Country> InsertAsync(Country country)
        {
            return await _countries.InsertAsync(country);
        }

        public async Task<Country> UpdateAsync(Country country)
        {
            return await _countries.UpdateAsync(country); 
        }
    }
}
