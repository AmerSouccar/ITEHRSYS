using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Services
{
    public class UniversityDomainService : IUniversityDomainService
    {
        private readonly IRepository<University, Guid> _universities;

        public UniversityDomainService(IRepository<University, Guid> universities)
        {
            _universities = universities;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _universities.DeleteAsync(id);
        }

        public async Task<University> GetbyId(Guid id)
        {
            return await _universities.GetAsync (id);
        }

        public async Task<List<University>> GetAllAsync()
        {
            return await _universities.GetAllListAsync();
        }

        public async Task<University> InsertAsync(University university)
        {
            return await _universities.InsertAsync(university);
        }

        public async Task<University> UpdateAsync(University university)
        {
            return await _universities.UpdateAsync(university);
        }
    }
}
