using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Countries.Services
{
    public interface ICountryAppService : IApplicationService
    {
        PagedResultDto<CountryDto> GetAll(PagedGeneralResultRequestDto input);
        Task<CountryDto> GetbyId(Guid id);
        Task<CountryDto> InsertAsync(CountryDto country);
        Task<CountryDto> UpdateAsync(CountryDto country);
        Task DeleteAsync(Guid id);
    }
}
