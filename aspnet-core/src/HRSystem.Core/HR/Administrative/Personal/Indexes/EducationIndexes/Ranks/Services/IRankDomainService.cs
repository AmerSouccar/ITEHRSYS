﻿using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Services
{
    public interface IRankDomainService : IDomainService
    {
        IQueryable<Rank> GetAll();
        Task<Rank> GetbyId(Guid id);
        Task<Rank> InsertAsync(Rank rank);
        Task<Rank> UpdateAsync(Rank rank);
        Task DeleteAsync(Guid id);
    }
}
