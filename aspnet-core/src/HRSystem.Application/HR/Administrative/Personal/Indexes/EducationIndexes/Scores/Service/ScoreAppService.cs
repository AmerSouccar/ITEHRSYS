using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Service
{
    internal class ScoreAppService : HRSystemAppServiceBase, IScoreAppService
    {
        private readonly IScoreDomainService _scoreDomainService;

        public ScoreAppService(IScoreDomainService scoreDomainService)
        {
            _scoreDomainService = scoreDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _scoreDomainService.DeleteAsync(id);
        }

        public async Task<List<ScoreDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<ScoreDto>>(await _scoreDomainService.GetAllAsync());
        }

        public async Task<ScoreDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ScoreDto>(await _scoreDomainService.GetbyId(id));
        }

        public async Task<ScoreDto> InsertAsync(ScoreDto score)
        {
            return ObjectMapper.Map<ScoreDto>(await _scoreDomainService.InsertAsync(ObjectMapper.Map<Score>(score)));
        }

        public async Task<ScoreDto> UpdateAsync(ScoreDto score)
        {
            return ObjectMapper.Map<ScoreDto>(await _scoreDomainService.UpdateAsync(ObjectMapper.Map<Score>(score)));

        }
    }
}
