using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Service
{
    public class NationalityAppService : HRSystemAppServiceBase, INationalityAppService
    {
        private readonly INationalityDomainService _nationalityDomainService;

        public NationalityAppService(INationalityDomainService nationalityDomainService)
        {
            _nationalityDomainService = nationalityDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _nationalityDomainService.DeleteAsync(id);
        }

        public PagedResultDto<NationalityDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var nationalites = _nationalityDomainService.GetAll();
            int total = nationalites.Count();
            nationalites = nationalites.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<NationalityDto>>(nationalites.ToList());
            return new PagedResultDto<NationalityDto>(total, list);
        }

        public async Task<NationalityDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.GetbyId(id));
        }

        public async Task<NationalityDto> InsertAsync(NationalityDto nationality)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.InsertAsync(ObjectMapper.Map<Nationality>(nationality)));
        }

        public async Task<NationalityDto> UpdateAsync(NationalityDto nationality)
        {
            return ObjectMapper.Map<NationalityDto>(await _nationalityDomainService.UpdateAsync(ObjectMapper.Map<Nationality>(nationality)));

        }
    }
}
