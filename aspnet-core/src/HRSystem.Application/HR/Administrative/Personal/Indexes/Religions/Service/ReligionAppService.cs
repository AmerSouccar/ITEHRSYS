using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Service
{
    public class ReligionAppService : HRSystemAppServiceBase, IReligionAppService
    {
        private readonly IReligionDomainService _religionDomainService;

        public ReligionAppService(IReligionDomainService religionDomainService)
        {
            _religionDomainService = religionDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
           await _religionDomainService.DeleteAsync(id);
        }

        public PagedResultDto<ReligionDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var religions = _religionDomainService.GetAll();
            int total = religions.Count();
            religions = religions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReligionDto>>(religions.ToList());
            return new PagedResultDto<ReligionDto>(total, list);
        }

        public async Task<ReligionDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReligionDto>(await _religionDomainService.GetbyId(id));
        }

        public async Task<ReligionDto> InsertAsync(ReligionDto religion)
        {
           return ObjectMapper.Map<ReligionDto>(await _religionDomainService.InsertAsync(ObjectMapper.Map<Religion> (religion)));
        }

        public async Task<ReligionDto> UpdateAsync(ReligionDto religion)
        {
            return ObjectMapper.Map<ReligionDto>(await _religionDomainService.UpdateAsync(ObjectMapper.Map<Religion>(religion)));

        }
    }
}
