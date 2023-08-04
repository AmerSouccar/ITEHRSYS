using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Service
{
    public class UniversityAppService : HRSystemAppServiceBase, IUniversityAppService
    {
        private readonly IUniversityDomainService _universitydomainService;

        public UniversityAppService(IUniversityDomainService universitydomainService)
        {
            _universitydomainService = universitydomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _universitydomainService.DeleteAsync(id);
        }

        public PagedResultDto<UniversityDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var universities = _universitydomainService.GetAll();
            int total = universities.Count();
            universities = universities.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<UniversityDto>>(universities.ToList());
            return new PagedResultDto<UniversityDto>(total, list);
        }

        public async Task<UniversityDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<UniversityDto>(await _universitydomainService.GetbyId(id));
        }

        public async Task<UniversityDto> InsertAsync(UniversityDto university)
        {
          return ObjectMapper.Map<UniversityDto>(await _universitydomainService.InsertAsync(ObjectMapper.Map<University>(university)));
        }

        public async Task<UniversityDto> UpdateAsync(UniversityDto university)
        {
            return ObjectMapper.Map<UniversityDto>(await _universitydomainService.UpdateAsync(ObjectMapper.Map<University>(university)));

        }
    }
}
