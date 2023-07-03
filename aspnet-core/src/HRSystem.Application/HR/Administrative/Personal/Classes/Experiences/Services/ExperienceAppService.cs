using HRSystem.HR.Administrative.Personal.Classes.Experiences.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Services
{
    public class ExperienceAppService : HRSystemAppServiceBase, IExperienceAppService
    {
        private readonly IExperienceDomainService _experienceDomainService;

        public ExperienceAppService(IExperienceDomainService experienceDomainService)
        {
            _experienceDomainService = experienceDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _experienceDomainService.Delete(id);
        }

        public async Task<List<ReadExperienceDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadExperienceDto>>(await _experienceDomainService.GetAll());
        }

        public async Task<ReadExperienceDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadExperienceDto>(await _experienceDomainService.GetbyId(id));
        }

        public async Task<InsertExperienceDto> Insert(InsertExperienceDto experience)
        {
            return ObjectMapper.Map<InsertExperienceDto>(await _experienceDomainService.Insert(ObjectMapper.Map<Experience>(experience)));
        }

        public async Task<UpdateExperienceDto> Update(UpdateExperienceDto experience)
        {
            return ObjectMapper.Map<UpdateExperienceDto>(await _experienceDomainService.Update(ObjectMapper.Map<Experience>(experience)));
        }
    }
}
