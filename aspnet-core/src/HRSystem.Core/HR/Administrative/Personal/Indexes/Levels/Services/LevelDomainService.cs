using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Levels.Services
{
    public class LevelDomainService : ILevelDomainService
    {
        private readonly IRepository<Level, Guid> _levels;

        public LevelDomainService(IRepository<Level, Guid> levels)
        {
            _levels = levels;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _levels.DeleteAsync(id);
        }

        public async Task<Level> GetbyId(Guid id)
        {
            return await _levels.GetAsync(id);
        }

        public async Task<List<Level>> GetCitiesAsync()
        {
            return await _levels.GetAllListAsync();
        }

        public async Task<Level> InsertAsync(Level level)
        {
            return await _levels.InsertAsync(level);
        }

        public async Task<Level> UpdateAsync(Level level)
        {
            return await _levels.UpdateAsync(level);
        }
    }
}
