using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Services
{
    public class ReligionDomainService : IReligionDomainService
    {
        private readonly IRepository<Religion, Guid> _religions;

        public ReligionDomainService(IRepository<Religion, Guid> religions)
        {
            _religions = religions;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _religions.DeleteAsync(id);
        }

        public async Task<Religion> GetbyId(Guid id)
        {
            return await _religions.GetAsync(id);
        }

        public IQueryable<Religion> GetAll()
        {
            return _religions.GetAll();
        }

        public async Task<Religion> InsertAsync(Religion religion)
        {
            return await _religions.InsertAsync(religion);
        }

        public async Task<Religion> UpdateAsync(Religion religion)
        {
            return await _religions.UpdateAsync(religion);
        }
    }
}
