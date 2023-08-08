using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Services;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ScoreTypeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var scoreTypes = _scoreTypeDomainService.GetAll();
            int total = scoreTypes.Count();
            scoreTypes = scoreTypes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ScoreTypeDto>>(scoreTypes.ToList());
            return new PagedResultDto<ScoreTypeDto>(total, list);
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
