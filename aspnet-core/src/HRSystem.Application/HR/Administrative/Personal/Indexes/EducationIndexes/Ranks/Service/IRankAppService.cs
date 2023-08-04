using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Service
{
    public interface IRankAppService : IApplicationService
    {
        PagedResultDto<RankDto> GetAll(PagedGeneralResultRequestDto input);
        Task<RankDto> GetbyId(Guid id);
        Task<RankDto> InsertAsync(RankDto rank);
        Task<RankDto> UpdateAsync(RankDto rank);
        Task DeleteAsync(Guid id);
    }
}
