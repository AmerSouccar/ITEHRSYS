using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Service
{
    public interface INationalityAppService :IApplicationService
    {
        Task<List<NationalityDto>> GetAllAsync();
        Task<NationalityDto> GetbyId(Guid id);
        Task<NationalityDto> InsertAsync(NationalityDto nationality);
        Task<NationalityDto> UpdateAsync(NationalityDto nationality);
        Task DeleteAsync(Guid id);
    }
}
