using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Services
{
    public class EducationAppService : HRSystemAppServiceBase, IEducationAppService
    {
        private readonly IEducationDomainService _educationDomainService;

        public EducationAppService(IEducationDomainService educationDomainService)
        {
            _educationDomainService = educationDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _educationDomainService.Delete(id);
        }

        public async Task<List<ReadEducationDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadEducationDto>>(await _educationDomainService.GetAll());
        }

        public async Task<ReadEducationDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadEducationDto>(await _educationDomainService.GetbyId(id));
        }

        public async Task<InsertEducationDto> Insert(InsertEducationDto education)
        {
            return ObjectMapper.Map<InsertEducationDto>(await _educationDomainService.Insert(ObjectMapper.Map<Education>(education)));
        }

        public async Task<UpdateEducationDto> Update(UpdateEducationDto education)
        {
            return ObjectMapper.Map<UpdateEducationDto>(await _educationDomainService.Update(ObjectMapper.Map<Education>(education)));

        }
    }
}
