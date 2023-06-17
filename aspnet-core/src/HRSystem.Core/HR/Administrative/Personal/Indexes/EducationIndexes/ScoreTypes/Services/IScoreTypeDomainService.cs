using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Services
{
    public interface IScoreTypeDomainService : IDomainService
    {
        Task<List<ScoreType>> GetCitiesAsync();
        Task<ScoreType> GetbyId(Guid id);
        Task<ScoreType> InsertAsync(ScoreType scoreType);
        Task<ScoreType> UpdateAsync(ScoreType scoreType);
        Task DeleteAsync(Guid id);

    }
}
