using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Service
{
    public interface ILanguageNameAppService : IApplicationService
    {
        Task<List<LanguageNameDto>> GetAllAsync();
        Task<LanguageNameDto> GetbyId(Guid id);
        Task<LanguageNameDto> InsertAsync(LanguageNameDto languageName);
        Task<LanguageNameDto> UpdateAsync(LanguageNameDto languageName);
        Task DeleteAsync(Guid id);
    }
}
