using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Passports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Services
{
    public interface ISkillDomainService :IDomainService
    {
        public IQueryable<Skill> GetAll();
        public Task<Skill> GetbyId(Guid id);
        public Task<Skill> Insert(Skill skill);
        public Task<Skill> Update(Skill skill);
        public Task Delete(Guid id);
    }
}
