using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Levels.Service
{
    public class LevelAppService : HRSystemAppServiceBase, ILevelAppService
    {
        private readonly ILevelDomainService _levelDomainService;

        public LevelAppService(ILevelDomainService levelDomainService)
        {
            _levelDomainService = levelDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _levelDomainService.DeleteAsync(id);
        }

        public PagedResultDto<LevelDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var levels = _levelDomainService.GetAll();
            int total = levels.Count();
            levels = levels.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<LevelDto>>(levels.ToList());
            return new PagedResultDto<LevelDto>(total, list);
        }

        public async Task<LevelDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<LevelDto>(await _levelDomainService.GetbyId(id));
        }

        public async Task<LevelDto> InsertAsync(LevelDto level)
        {
            return ObjectMapper.Map<LevelDto>(await _levelDomainService.InsertAsync(ObjectMapper.Map<Level>(level)));
        }

        public async Task<LevelDto> UpdateAsync(LevelDto level)
        {
            return ObjectMapper.Map<LevelDto>(await _levelDomainService.UpdateAsync(ObjectMapper.Map<Level>(level)));

        }
    }
}
