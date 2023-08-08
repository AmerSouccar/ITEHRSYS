using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Services
{
    public interface ILeaveSettingDomainService :IDomainService
    {
        public Task<List<LeaveSetting>> GetAll();
        public Task<LeaveSetting> GetbyId(Guid id);
        public Task<LeaveSetting> Insert(LeaveSetting leaveSetting);
        public Task<LeaveSetting> Update(LeaveSetting leaveSetting);
        public Task Delete(Guid id);
    }
}
