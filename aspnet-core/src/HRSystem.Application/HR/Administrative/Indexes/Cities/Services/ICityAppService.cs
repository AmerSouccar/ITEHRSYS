using Abp.Application.Services;
using HRSystem.HR.Administrative.Indexes.Cities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Indexes.Cities.Services
{
    public interface ICityAppService : IApplicationService
    {
        Task<List<CityDto>> GetCitiesAsync();
        Task<CityDto> GetbyId(Guid id);
        Task<CityDto> InsertAsync(CityDto city);
        Task<CityDto> UpdateAsync(CityDto city);
        Task DeleteAsync(Guid id);
    }
}
