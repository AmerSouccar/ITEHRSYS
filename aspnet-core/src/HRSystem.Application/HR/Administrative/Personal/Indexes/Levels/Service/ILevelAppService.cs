using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Levels.Service
{
    public interface ILevelAppService : IApplicationService
    {
        PagedResultDto<LevelDto> GetAll(PagedGeneralResultRequestDto input);
        Task<LevelDto> GetbyId(Guid id);
        Task<LevelDto> InsertAsync(LevelDto level);
        Task<LevelDto> UpdateAsync(LevelDto level);
        Task DeleteAsync(Guid id);
    }
}
