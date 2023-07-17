using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Services
{
    public interface IChangeableHolidayDomainService :IDomainService
    {
        public Task<List<ChangeableHoliday>> GetAll();
        public Task<ChangeableHoliday> GetbyId(Guid id);
        public Task<ChangeableHoliday> Insert(ChangeableHoliday changeableHoliday);
        public Task<ChangeableHoliday> Update(ChangeableHoliday changeableHoliday);
        public Task Delete(Guid id);
    }
}
