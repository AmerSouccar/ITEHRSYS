using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Services
{
    internal class DriverLicenseDomainService : IDriverLicenseDomainService
    {
        private readonly IRepository<DriverLicense, Guid> _driverLicenseRepository;

        public DriverLicenseDomainService(IRepository<DriverLicense, Guid> driverLicenseRepository)
        {
            _driverLicenseRepository = driverLicenseRepository;
        }

        public async Task Delete(Guid id)
        {
            await _driverLicenseRepository.DeleteAsync(id);
        }

        public async Task<List<DriverLicense>> GetAll()
        {
            return _driverLicenseRepository.GetAllIncluding(x => x.DriverLicenseType, x => x.PlaceofIssuance, x => x.Attachments).ToList() ;
        }

        public async Task<DriverLicense> GetbyId(Guid id)
        {
            return _driverLicenseRepository.GetAllIncluding(x => x.DriverLicenseType, x => x.PlaceofIssuance, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<DriverLicense> Insert(DriverLicense driverLicense)
        {
            return await _driverLicenseRepository.InsertAsync(driverLicense);
        }

        public async Task<DriverLicense> Update(DriverLicense driverLicense)
        {
            return await _driverLicenseRepository.UpdateAsync(driverLicense);
        }
    }
}
