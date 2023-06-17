using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Services
{
    public interface IEducationTypeDomainService : IDomainService
    {
        Task<List<EducationType>> GetCitiesAsync();
        Task<EducationType> GetbyId(Guid id);
        Task<EducationType> InsertAsync(EducationType educationType);
        Task<EducationType> UpdateAsync(EducationType educationType);
        Task DeleteAsync(Guid id);
    }
}
