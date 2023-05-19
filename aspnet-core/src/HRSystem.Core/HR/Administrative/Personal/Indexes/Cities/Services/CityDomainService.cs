using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Cities.Services
{
    public class CityDomainService : ICityDomainService
    {
        private readonly IRepository<City, Guid> _cities;

        public CityDomainService(IRepository<City, Guid> cities)
        {
            _cities = cities;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _cities.DeleteAsync(id);
        }

        public async Task<City> GetbyId(Guid id)
        {
            return await _cities.GetAsync(id);
        }

        public async Task<List<City>> GetCitiesAsync()
        {
            return await _cities.GetAllListAsync();
        }

        public async Task<City> InsertAsync(City city)
        {
            return await _cities.InsertAsync(city);
        }

        public async Task<City> UpdateAsync(City city)
        {
            return await _cities.UpdateAsync(city);
        }
    }
}
