using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Services
{
    public class ScoreDomainService : IScoreDomainService
    {
        private readonly IRepository<Score, Guid> _scores;

        public ScoreDomainService(IRepository<Score, Guid> scores)
        {
            _scores = scores;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _scores.DeleteAsync (id);
        }

        public async Task<Score> GetbyId(Guid id)
        {
            return await _scores.GetAsync(id);
        }

        public async Task<List<Score>> GetAllAsync()
        {
            return await _scores.GetAllListAsync();
        }

        public async Task<Score> InsertAsync(Score score)
        {
            return await _scores.InsertAsync(score);
        }

        public async Task<Score> UpdateAsync(Score score)
        {
            return await _scores.UpdateAsync(score);
        }
    }
}
