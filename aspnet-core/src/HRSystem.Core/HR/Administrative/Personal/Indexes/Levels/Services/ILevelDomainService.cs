using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Levels.Services
{
    public interface ILevelDomainService : IDomainService
    {
        Task<List<Level>> GetCitiesAsync();
        Task<Level> GetbyId(Guid id);
        Task<Level> InsertAsync(Level level);
        Task<Level> UpdateAsync(Level level);
        Task DeleteAsync(Guid id);

    }
}
