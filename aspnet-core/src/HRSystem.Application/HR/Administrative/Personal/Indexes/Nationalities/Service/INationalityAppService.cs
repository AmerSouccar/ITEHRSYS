using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Service
{
    public interface INationalityAppService :IApplicationService
    {
        PagedResultDto<NationalityDto> GetAll(PagedGeneralResultRequestDto input);
        Task<NationalityDto> GetbyId(Guid id);
        Task<NationalityDto> InsertAsync(NationalityDto nationality);
        Task<NationalityDto> UpdateAsync(NationalityDto nationality);
        Task DeleteAsync(Guid id);
    }
}
