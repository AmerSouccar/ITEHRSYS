using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Services
{
    public class NationalityDomainService : INationalityDomainService
    {
        private readonly IRepository<Nationality, Guid> _nationalities;

        public NationalityDomainService(IRepository<Nationality, Guid> nationalities)
        {
            _nationalities = nationalities;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _nationalities.DeleteAsync(id);
        }

        public async Task<Nationality> GetbyId(Guid id)
        {
            return await _nationalities.GetAsync(id);
        }

        public async Task<List<Nationality>> GetAllAsync()
        {
            return await _nationalities.GetAllListAsync();
        }

        public async Task<Nationality> InsertAsync(Nationality nationality)
        {
            return await _nationalities.InsertAsync(nationality);
        }

        public async Task<Nationality> UpdateAsync(Nationality nationality)
        {
            return await _nationalities.UpdateAsync(nationality);
        }
    }
}
