using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Service
{
    public interface ILanguageNameAppService : IApplicationService
    {
        PagedResultDto<LanguageNameDto> GetAll(PagedGeneralResultRequestDto input);
        Task<LanguageNameDto> GetbyId(Guid id);
        Task<LanguageNameDto> InsertAsync(LanguageNameDto languageName);
        Task<LanguageNameDto> UpdateAsync(LanguageNameDto languageName);
        Task DeleteAsync(Guid id);
    }
}
