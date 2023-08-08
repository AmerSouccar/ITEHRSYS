using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Services
{
    public class DriverLicenseTypeDomainService : IDriverLicenseTypeDomainService
    {
        private readonly IRepository<DriverLicenseType, Guid> _driverLicenseTypes;

        public DriverLicenseTypeDomainService(IRepository<DriverLicenseType, Guid> driverLicenseTypes)
        {
            _driverLicenseTypes = driverLicenseTypes;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _driverLicenseTypes.DeleteAsync(id);

        }

        public async Task<DriverLicenseType> GetbyId(Guid id)
        {
            return await _driverLicenseTypes.GetAsync(id);
        }

        public IQueryable<DriverLicenseType> GetAll()
        {
            return _driverLicenseTypes.GetAll();
        }

        public async Task<DriverLicenseType> InsertAsync(DriverLicenseType driverLicenseType)
        {
            return await _driverLicenseTypes.InsertAsync(driverLicenseType);

        }

        public async Task<DriverLicenseType> UpdateAsync(DriverLicenseType driverLicenseType)
        {
            return await _driverLicenseTypes.UpdateAsync(driverLicenseType);
        }
    }


}
