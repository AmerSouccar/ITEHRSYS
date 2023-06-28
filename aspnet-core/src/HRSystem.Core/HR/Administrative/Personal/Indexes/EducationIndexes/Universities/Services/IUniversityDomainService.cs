using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Services
{
    public interface IUniversityDomainService : IDomainService
    {
        Task<List<University>> GetAllAsync();
        Task<University> GetbyId(Guid id);
        Task<University> InsertAsync(University university);
        Task<University> UpdateAsync(University university);
        Task DeleteAsync(Guid id);

    }
}
