using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Services
{
    public interface IReligionDomainService :IDomainService
    {
        Task<List<Religion>> GetAllsAsync();
        Task<Religion> GetbyId(Guid id);
        Task<Religion> InsertAsync(Religion religion);
        Task<Religion> UpdateAsync(Religion religion);
        Task DeleteAsync(Guid id);

    }
}
