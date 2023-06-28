using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Service
{
    public interface IScoreAppService : IApplicationService
    {
        Task<List<ScoreDto>> GetAllAsync();
        Task<ScoreDto> GetbyId(Guid id);
        Task<ScoreDto> InsertAsync(ScoreDto score);
        Task<ScoreDto> UpdateAsync(ScoreDto score);
        Task DeleteAsync(Guid id);
    }
}
