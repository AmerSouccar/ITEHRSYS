using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Services
{
    public class EducationTypeDomainService : IEducationTypeDomainService
    {
        private readonly IRepository<EducationType, Guid> _educationTypes;

        public EducationTypeDomainService(IRepository<EducationType, Guid> educationTypes)
        {
            _educationTypes = educationTypes;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _educationTypes.DeleteAsync(id);
        }

        public async Task<EducationType> GetbyId(Guid id)
        {
            return await _educationTypes.GetAsync (id);
        }

        public async Task<List<EducationType>> GetCitiesAsync()
        {
            return await _educationTypes.GetAllListAsync();
        }

        public async Task<EducationType> InsertAsync(EducationType educationType)
        {
            return await _educationTypes.InsertAsync(educationType);
        }

        public async Task<EducationType> UpdateAsync(EducationType educationType)
        {
            return await _educationTypes.UpdateAsync(educationType);
        }
    }
}
