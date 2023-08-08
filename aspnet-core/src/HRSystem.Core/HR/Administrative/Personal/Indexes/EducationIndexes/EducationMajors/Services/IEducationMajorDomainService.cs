using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Services
{
    public interface IEducationMajorDomainService : IDomainService
    {
        IQueryable<EducationMajor> GetAll();
        Task<EducationMajor> GetbyId(Guid id);
        Task<EducationMajor> InsertAsync(EducationMajor educationMajor);
        Task<EducationMajor> UpdateAsync(EducationMajor educationMajor);
        Task DeleteAsync(Guid id);
    }
}
