using Abp.Domain.Repositories;
using HRSystem.HR.Administrative.OrgChart.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Services
{
    public class ScoreTypeDomainService : IScoreTypeDomainService
    {
        private readonly IRepository<ScoreType, Guid> _scoreTypes;

        public ScoreTypeDomainService(IRepository<ScoreType, Guid> scoreTypes)
        {
            _scoreTypes = scoreTypes;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _scoreTypes.DeleteAsync (id);
        }

        public async Task<ScoreType> GetbyId(Guid id)
        {
            return await _scoreTypes.GetAsync (id);
        }

        public async Task<List<ScoreType>> GetCitiesAsync()
        {
            return await _scoreTypes.GetAllListAsync();
        }

        public async Task<ScoreType> InsertAsync(ScoreType scoreType)
        {
             return await _scoreTypes.InsertAsync(scoreType);
        }

        public async Task<ScoreType> UpdateAsync(ScoreType scoreType)
        {
            return await _scoreTypes.UpdateAsync(scoreType);
        }
    }
}
