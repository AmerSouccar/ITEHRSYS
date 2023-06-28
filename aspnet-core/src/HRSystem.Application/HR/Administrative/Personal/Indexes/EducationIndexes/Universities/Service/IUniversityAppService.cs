using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities.Service
{
    public interface IUniversityAppService : IApplicationService
    {
        Task<List<UniversityDto>> GetAllAsync();
        Task<UniversityDto> GetbyId(Guid id);
        Task<UniversityDto> InsertAsync(UniversityDto university);
        Task<UniversityDto> UpdateAsync(UniversityDto university);
        Task DeleteAsync(Guid id);
    }
}
