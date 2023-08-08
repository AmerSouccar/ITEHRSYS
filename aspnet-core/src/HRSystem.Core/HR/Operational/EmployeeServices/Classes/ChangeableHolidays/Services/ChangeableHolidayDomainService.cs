using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Services
{
    public class ChangeableHolidayDomainService : IChangeableHolidayDomainService
    {
        private readonly IRepository<ChangeableHoliday, Guid> _changeableHolidayRepository;

        public ChangeableHolidayDomainService(IRepository<ChangeableHoliday, Guid> changeableHolidayRepository)
        {
            _changeableHolidayRepository = changeableHolidayRepository;
        }

        public async Task Delete(Guid id)
        {
            await _changeableHolidayRepository.DeleteAsync(id);
        }

        public async Task<List<ChangeableHoliday>> GetAll()
        {
            return await _changeableHolidayRepository.GetAllListAsync();
        }

        public Task<ChangeableHoliday> GetbyId(Guid id)
        {
            return _changeableHolidayRepository.GetAsync(id);
        }

        public async Task<ChangeableHoliday> Insert(ChangeableHoliday changeableHoliday)
        {
            return await _changeableHolidayRepository.InsertAsync(changeableHoliday);
        }

        public async Task<ChangeableHoliday> Update(ChangeableHoliday changeableHoliday)
        {
            return await _changeableHolidayRepository.UpdateAsync(changeableHoliday);

        }
    }
}
