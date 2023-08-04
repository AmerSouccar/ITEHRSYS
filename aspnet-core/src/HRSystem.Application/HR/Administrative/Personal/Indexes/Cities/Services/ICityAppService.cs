using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Cities.Services
{
    public interface ICityAppService : IApplicationService
    {
        PagedResultDto<CityDto> GetAll(PagedGeneralResultRequestDto input);
        Task<CityDto> GetbyId(Guid id);
        Task<CityDto> InsertAsync(CityDto city);
        Task<CityDto> UpdateAsync(CityDto city);
        Task DeleteAsync(Guid id);
    }
}
