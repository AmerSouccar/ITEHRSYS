using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Services
{
    public interface IDriverLicenseTypeDomainService :IDomainService
    {
        IQueryable<DriverLicenseType> GetAll();
        Task<DriverLicenseType> GetbyId(Guid id);
        Task<DriverLicenseType> InsertAsync(DriverLicenseType driverLicenseType);
        Task<DriverLicenseType> UpdateAsync(DriverLicenseType driverLicenseType);
        Task DeleteAsync(Guid id);
    }
}
