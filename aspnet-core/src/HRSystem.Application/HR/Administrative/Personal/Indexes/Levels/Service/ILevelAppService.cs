using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Levels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Levels.Service
{
    public interface ILevelAppService : IApplicationService
    {
        Task<List<LevelDto>> GetAllAsync();
        Task<LevelDto> GetbyId(Guid id);
        Task<LevelDto> InsertAsync(LevelDto level);
        Task<LevelDto> UpdateAsync(LevelDto level);
        Task DeleteAsync(Guid id);
    }
}
