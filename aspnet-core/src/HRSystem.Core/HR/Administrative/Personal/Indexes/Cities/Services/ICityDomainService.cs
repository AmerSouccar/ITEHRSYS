using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Cities.Services
{
    public interface ICityDomainService : IDomainService
    {
        IQueryable<City> GetAll();
        Task<City> GetbyId(Guid id);
        Task<City> InsertAsync(City city);
        Task<City> UpdateAsync(City city);
        Task DeleteAsync(Guid id);

    }
}
