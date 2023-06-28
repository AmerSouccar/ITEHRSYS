using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Service
{
    public interface IRankAppService : IApplicationService
    {
        Task<List<RankDto>> GetAllAsync();
        Task<RankDto> GetbyId(Guid id);
        Task<RankDto> InsertAsync(RankDto rank);
        Task<RankDto> UpdateAsync(RankDto rank);
        Task DeleteAsync(Guid id);
    }
}
