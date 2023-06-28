using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Services;
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

        public async Task<List<LevelDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<LevelDto>>(await _levelDomainService.GetAllAsync());
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
