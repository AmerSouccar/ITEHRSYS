using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Services
{
    public interface ICompanyHolidayDomainService :IDomainService
    {
        public Task<List<CompanyHoliday>> GetAll();
        public Task<CompanyHoliday> GetbyId(Guid id);
        public Task<CompanyHoliday> Insert(CompanyHoliday companyHoliday);
        public Task<CompanyHoliday> Update(CompanyHoliday companyHoliday);
        public Task Delete(Guid id);
    }
}
