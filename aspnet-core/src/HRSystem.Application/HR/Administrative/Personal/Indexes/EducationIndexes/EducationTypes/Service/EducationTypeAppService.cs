using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Services;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<EducationTypeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var educationTypes = _educationTypeDomainService.GetAll();
            int total = educationTypes.Count();
            educationTypes = educationTypes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<EducationTypeDto>>(educationTypes.ToList());
            return new PagedResultDto<EducationTypeDto>(total, list);
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
