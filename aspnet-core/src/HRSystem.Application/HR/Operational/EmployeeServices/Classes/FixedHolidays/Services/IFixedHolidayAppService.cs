using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services
{
    public interface IFixedHolidayAppService :IApplicationService
    {
        public Task<List<ReadFixedHolidayDto>> GetAll();
        public Task<ReadFixedHolidayDto> GetbyId(Guid id);
        public Task<InsertFixedHolidayDto> Insert(InsertFixedHolidayDto fixedHoliday);
        public Task<UpdateFixedHolidayDto> Update(UpdateFixedHolidayDto fixedHoliday);
        public Task Delete(Guid id);
    }
}
