using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Services
{
    public interface IScoreDomainService :IDomainService
    {
        Task<List<Score>> GetCitiesAsync();
        Task<Score> GetbyId(Guid id);
        Task<Score> InsertAsync(Score score);
        Task<Score> UpdateAsync(Score score);
        Task DeleteAsync(Guid id);

    }
}
