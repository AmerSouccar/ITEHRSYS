using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services
{
    public class FixedHolidayDomainService : IFixedHolidayDomainService
    {
        private readonly IRepository<FixedHoliday,Guid> _fixedHolidayRepository;
        public async Task Delete(Guid id)
        {
            await _fixedHolidayRepository.DeleteAsync(id);
        }

        public async Task<List<FixedHoliday>> GetAll()
        {
            return await _fixedHolidayRepository.GetAllListAsync();
        }

        public Task<FixedHoliday> GetbyId(Guid id)
        {
            return _fixedHolidayRepository.GetAsync(id);
        }

        public async Task<FixedHoliday> Insert(FixedHoliday fixedHoliday)
        {
            return await _fixedHolidayRepository.InsertAsync(fixedHoliday);
        }

        public async Task<FixedHoliday> Update(FixedHoliday fixedHoliday)
        {
            return await _fixedHolidayRepository.UpdateAsync(fixedHoliday);

        }
    }
}
