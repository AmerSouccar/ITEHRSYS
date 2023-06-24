using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Services
{
    public class EducationDomainService : IEducationDomainService
    {
        private readonly IRepository<Education, Guid> _educationRepository;

        public EducationDomainService(IRepository<Education, Guid> educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public async Task Delete(Guid id)
        {
            await _educationRepository.DeleteAsync(id);
        }

        public async Task<List<Education>> GetAll()
        {
            return _educationRepository.GetAllIncluding(x => x.Type, x => x.Major, x => x.University, x => x.Rank, x => x.ScoreType, x => x.Score, x => x.Country, x => x.Attachments).ToList();
        }

        public async Task<Education> GetbyId(Guid id)
        {
            return _educationRepository.GetAllIncluding(x => x.Type, x => x.Major, x => x.University, x => x.Rank, x => x.ScoreType, x => x.Score, x => x.Country, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Education> Insert(Education education)
        {
            return await _educationRepository.InsertAsync(education);
        }

        public async Task<Education> Update(Education education)
        {
            return await _educationRepository.UpdateAsync(education);
        }
    }
}
