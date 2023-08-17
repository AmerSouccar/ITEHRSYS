using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Services
{
    public class CompanyHolidayDomainService : ICompanyHolidayDomainService
    {
        private readonly IRepository<CompanyHoliday,Guid> _companyHolidayRepository;

        public CompanyHolidayDomainService(IRepository<CompanyHoliday, Guid> companyHolidayRepository)
        {
            _companyHolidayRepository = companyHolidayRepository;
        }

        public async Task Delete(Guid id)
        {
            await _companyHolidayRepository.DeleteAsync(id);
        }

        public IQueryable<CompanyHoliday> GetAll()
        {
            return _companyHolidayRepository.GetAll();
        }

        public Task<CompanyHoliday> GetbyId(Guid id)
        {
           return _companyHolidayRepository.GetAsync(id);
        }

        public async Task<CompanyHoliday> Insert(CompanyHoliday companyHoliday)
        {
           return await _companyHolidayRepository.InsertAsync(companyHoliday);
        }

        public async Task<CompanyHoliday> Update(CompanyHoliday companyHoliday)
        {
            return await _companyHolidayRepository.UpdateAsync(companyHoliday);

        }
    }
}
