using HRSystem.HR.Administrative.Personal.Classes.Skills.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Services
{
    public class SkillAppService : HRSystemAppServiceBase, ISkillAppService
    {
        private readonly ISkillDomainService _skillDomainService;

        public SkillAppService(ISkillDomainService skillDomainService)
        {
            _skillDomainService = skillDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _skillDomainService.Delete(id);
        }

        public async Task<List<ReadSkillDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadSkillDto>>(await _skillDomainService.GetAll());
        }

        public async Task<ReadSkillDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadSkillDto>(await _skillDomainService.GetbyId(id));
        }

        public async Task<InsertSkillDto> Insert(InsertSkillDto skill)
        {
            return ObjectMapper.Map<InsertSkillDto>(await _skillDomainService.Insert(ObjectMapper.Map<Skill>(skill)));
        }

        public async Task<UpdateSkillDto> Update(UpdateSkillDto skill)
        {
            return ObjectMapper.Map<UpdateSkillDto>(await _skillDomainService.Update(ObjectMapper.Map<Skill>(skill)));

        }
    }
}
