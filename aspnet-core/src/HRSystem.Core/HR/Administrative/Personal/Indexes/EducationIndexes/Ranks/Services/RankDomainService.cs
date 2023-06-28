using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Services
{
    public class RankDomainService : IRankDomainService
    {
        private readonly IRepository<Rank, Guid> _ranks;

        public RankDomainService(IRepository<Rank, Guid> ranks)
        {
            _ranks = ranks;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _ranks.DeleteAsync (id);
        }

        public async Task<Rank> GetbyId(Guid id)
        {
            return await _ranks.GetAsync (id);
        }

        public async Task<List<Rank>> GetAllAsync()
        {
            return await _ranks.GetAllListAsync();
        }

        public async Task<Rank> InsertAsync(Rank rank)
        {
            return await _ranks.InsertAsync(rank);
        }

        public async Task<Rank> UpdateAsync(Rank rank)
        {
            return await _ranks.UpdateAsync(rank);
        }
    }
}
