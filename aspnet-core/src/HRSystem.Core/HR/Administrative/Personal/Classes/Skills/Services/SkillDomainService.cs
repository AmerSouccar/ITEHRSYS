using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Services
{
    public class SkillDomainService : ISkillDomainService
    {
        private readonly IRepository<Skill, Guid> _SkillRepository;

        public SkillDomainService(IRepository<Skill, Guid> skillRepository)
        {
            _SkillRepository = skillRepository;
        }

        public async Task Delete(Guid id)
        {
            await _SkillRepository.DeleteAsync(id);
        }

        public IQueryable<Skill> GetAll()
        {
            return _SkillRepository.GetAllIncluding(x => x.Level, x => x.Attachments);
        }

        public async Task<Skill> GetbyId(Guid id)
        {
            return _SkillRepository.GetAllIncluding(x => x.Level, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Skill> Insert(Skill skill)
        {
            return await _SkillRepository.InsertAsync(skill);
        }

        public async Task<Skill> Update(Skill skill)
        {
            return await (_SkillRepository.UpdateAsync(skill));
        }
    }
}
