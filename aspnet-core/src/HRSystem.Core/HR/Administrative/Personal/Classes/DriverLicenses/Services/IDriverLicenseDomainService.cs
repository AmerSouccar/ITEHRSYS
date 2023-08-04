using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Custodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Services
{
    public interface IDriverLicenseDomainService :IDomainService
    {
        public IQueryable<DriverLicense> GetAll();
        public Task<DriverLicense> GetbyId(Guid id);
        public Task<DriverLicense> Insert(DriverLicense driverLicense);
        public Task<DriverLicense> Update(DriverLicense driverLicense);
        public Task Delete(Guid id);
    }
}
