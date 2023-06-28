using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Service
{
    public class ScoreTypeAppService : HRSystemAppServiceBase, IScoreTypeAppService
    {
        private readonly IScoreTypeDomainService _scoreTypeDomainService;

        public ScoreTypeAppService(IScoreTypeDomainService scoreTypeDomainService)
        {
            _scoreTypeDomainService = scoreTypeDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _scoreTypeDomainService.DeleteAsync(id);  
        }

        public async Task<List<ScoreTypeDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<ScoreTypeDto>>(await _scoreTypeDomainService.GetAllAsync());
        }

        public async Task<ScoreTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ScoreTypeDto>(await _scoreTypeDomainService.GetbyId(id));
        }

        public async Task<ScoreTypeDto> InsertAsync(ScoreTypeDto scoreType)
        {
           return ObjectMapper.Map<ScoreTypeDto>(await _scoreTypeDomainService.InsertAsync(ObjectMapper.Map<ScoreType>(scoreType)));
        }

        public async Task<ScoreTypeDto> UpdateAsync(ScoreTypeDto scoretype)
        {
            return ObjectMapper.Map<ScoreTypeDto>(await _scoreTypeDomainService.UpdateAsync(ObjectMapper.Map<ScoreType>(scoretype)));


        }
    }
}
