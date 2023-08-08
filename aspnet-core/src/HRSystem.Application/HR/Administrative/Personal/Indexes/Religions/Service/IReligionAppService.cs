using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Religions.Service
{
    public interface IReligionAppService : IApplicationService
    {
        PagedResultDto<ReligionDto> GetAll(PagedGeneralResultRequestDto input);
        Task<ReligionDto> GetbyId(Guid id);
        Task<ReligionDto> InsertAsync(ReligionDto religion);
        Task<ReligionDto> UpdateAsync(ReligionDto religion);
        Task DeleteAsync(Guid id);
    }
}
