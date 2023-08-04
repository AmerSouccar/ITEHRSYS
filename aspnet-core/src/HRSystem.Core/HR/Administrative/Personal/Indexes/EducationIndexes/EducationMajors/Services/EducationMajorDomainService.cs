using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Services
{
    public class EducationMajorDomainService : IEducationMajorDomainService
    {
        private readonly IRepository<EducationMajor, Guid> _educationMajors;

        public EducationMajorDomainService(IRepository<EducationMajor, Guid> educationMajors)
        {
            _educationMajors = educationMajors;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _educationMajors.DeleteAsync (id);
        }

        public async Task<EducationMajor> GetbyId(Guid id)
        {
            return await _educationMajors.GetAsync(id);
        }

        public IQueryable<EducationMajor> GetAll()
        {
            return _educationMajors.GetAll();
        }

        public async Task<EducationMajor> InsertAsync(EducationMajor educationMajor)
        {
            return await _educationMajors.InsertAsync(educationMajor);
        }

        public async Task<EducationMajor> UpdateAsync(EducationMajor educationMajor)
        {
            return await _educationMajors.UpdateAsync(educationMajor);
        }
    }
}
