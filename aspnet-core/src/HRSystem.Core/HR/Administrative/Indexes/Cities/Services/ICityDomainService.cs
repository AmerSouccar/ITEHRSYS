﻿using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Indexes.Cities.Services
{
    public interface ICityDomainService : IDomainService
    {
        Task<List<City>> GetCitiesAsync();
        Task<City> GetbyId(Guid id);
        Task<City> InsertAsync(City city);
        Task<City> UpdateAsync(City city);
        Task DeleteAsync(Guid id);

    }
}
