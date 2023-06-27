using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Services
{
    public interface IDriverLicenseTypeAppService : IApplicationService
    {
        Task<List<DriverLicenseTypeDto>> GetAllAsync();
        Task<DriverLicenseTypeDto> GetbyId(Guid id);
        Task<DriverLicenseTypeDto> InsertAsync(DriverLicenseTypeDto driverLicenseType);
        Task<DriverLicenseTypeDto> UpdateAsync(DriverLicenseTypeDto driverLicenseType);
        Task DeleteAsync(Guid id);
    }
}
