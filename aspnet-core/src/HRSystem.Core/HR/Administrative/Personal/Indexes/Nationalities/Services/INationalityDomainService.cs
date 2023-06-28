using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Services
{
    public interface INationalityDomainService : IDomainService
    {
        Task<List<Nationality>> GetAllAsync();
        Task<Nationality> GetbyId(Guid id);
        Task<Nationality> InsertAsync(Nationality nationality);
        Task<Nationality> UpdateAsync(Nationality nationality);
        Task DeleteAsync(Guid id);

    }
}
