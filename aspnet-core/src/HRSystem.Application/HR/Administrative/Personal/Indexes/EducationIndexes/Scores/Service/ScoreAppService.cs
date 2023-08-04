using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Services;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ScoreDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var scores = _scoreDomainService.GetAll();
            int total = scores.Count();
            scores = scores.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ScoreDto>>(scores.ToList());
            return new PagedResultDto<ScoreDto>(total, list);
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
