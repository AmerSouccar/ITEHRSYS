using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Skills.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Services
{
    public interface ISkillAppService : IApplicationService
    {
        public Task<List<ReadSkillDto>> GetAll();
        public Task<ReadSkillDto> GetbyId(Guid id);
        public Task<InsertSkillDto> Insert(InsertSkillDto skill);
        public Task<UpdateSkillDto> Update(UpdateSkillDto skill);
        public Task Delete(Guid id);
    }
}
