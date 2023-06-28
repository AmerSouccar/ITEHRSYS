using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Service
{
    public class EducationTypeAppService : HRSystemAppServiceBase, IEducationTypeAppService
    {
        private readonly IEducationTypeDomainService _educationTypeDomainService;

        public EducationTypeAppService(IEducationTypeDomainService educationTypeDomainService)
        {
            _educationTypeDomainService = educationTypeDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _educationTypeDomainService.DeleteAsync(id);
        }

        public async Task<List<EducationTypeDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<EducationTypeDto>>(await _educationTypeDomainService.GetAllAsync());
        }

        public async Task<EducationTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<EducationTypeDto>(await _educationTypeDomainService.GetbyId(id));
        }

        public async Task<EducationTypeDto> InsertAsync(EducationTypeDto educationType)
        {
            return ObjectMapper.Map<EducationTypeDto>(await _educationTypeDomainService.InsertAsync(ObjectMapper.Map<EducationType>(educationType)));
        }

        public async Task<EducationTypeDto> UpdateAsync(EducationTypeDto educationType)
        {
            return ObjectMapper.Map<EducationTypeDto>(await _educationTypeDomainService.UpdateAsync(ObjectMapper.Map<EducationType>(educationType)));
        }
    }
}
