using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services
{
    public interface IFixedHolidayDomainService : IDomainService
    {
        public IQueryable<FixedHoliday> GetAll();
        public Task<FixedHoliday> GetbyId(Guid id);
        public Task<FixedHoliday> Insert(FixedHoliday fixedHoliday);
        public Task<FixedHoliday> Update(FixedHoliday fixedHoliday);
        public Task Delete(Guid id);
    }
}
