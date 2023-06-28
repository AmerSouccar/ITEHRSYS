using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes.Service
{
    public interface IScoreTypeAppService :IApplicationService
    {
        Task<List<ScoreTypeDto>> GetAllAsync();
        Task<ScoreTypeDto> GetbyId(Guid id);
        Task<ScoreTypeDto> InsertAsync(ScoreTypeDto scoreType);
        Task<ScoreTypeDto> UpdateAsync(ScoreTypeDto scoretype);
        Task DeleteAsync(Guid id);
    }
}
