using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Services
{
    public class ExperienceDomainService : IExperienceDomainService
    {
        private readonly IRepository<Experience, Guid> _experienceRepository;

        public ExperienceDomainService(IRepository<Experience, Guid> experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public async Task Delete(Guid id)
        {
            await _experienceRepository.DeleteAsync(id);
        }

        public IQueryable<Experience> GetAll()
        {
            return _experienceRepository.GetAllIncluding(x => x.Attachments);
        }

        public async Task<Experience> GetbyId(Guid id)
        {
            return _experienceRepository.GetAllIncluding(x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Experience> Insert(Experience experience)
        {
            return await _experienceRepository.InsertAsync(experience);
        }

        public async Task<Experience> Update(Experience experience)
        {
            return await _experienceRepository.UpdateAsync(experience);
        }
    }
}
