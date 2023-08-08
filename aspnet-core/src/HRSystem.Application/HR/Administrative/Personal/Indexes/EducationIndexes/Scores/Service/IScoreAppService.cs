using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Service
{
    public interface IScoreAppService : IApplicationService
    {
        PagedResultDto<ScoreDto> GetAll(PagedGeneralResultRequestDto input);
        Task<ScoreDto> GetbyId(Guid id);
        Task<ScoreDto> InsertAsync(ScoreDto score);
        Task<ScoreDto> UpdateAsync(ScoreDto score);
        Task DeleteAsync(Guid id);
    }
}
