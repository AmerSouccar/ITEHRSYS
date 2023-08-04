using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Countries.Services
{
    public interface ICountryDomainService : IDomainService
    {
        IQueryable<Country> GetAll();
        Task<Country> GetbyId(Guid id);
        Task<Country> InsertAsync(Country country);
        Task<Country> UpdateAsync(Country country);
        Task DeleteAsync(Guid id);

    }
}