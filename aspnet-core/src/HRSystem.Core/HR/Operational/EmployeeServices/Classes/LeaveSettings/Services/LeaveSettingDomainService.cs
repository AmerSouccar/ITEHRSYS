using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Services
{
    public class LeaveSettingDomainService : ILeaveSettingDomainService
    {
        private readonly IRepository<LeaveSetting,Guid> _leaveSettingRepository;

        public LeaveSettingDomainService(IRepository<LeaveSetting, Guid> leaveSettingRepository)
        {
            _leaveSettingRepository = leaveSettingRepository;
        }

        public async Task Delete(Guid id)
        {
            await _leaveSettingRepository.DeleteAsync(id);
        }

        public async Task<List<LeaveSetting>> GetAll()
        {
            return _leaveSettingRepository.GetAllIncluding(x => x.EmployeeCard, x => x.WorkflowSetting).ToList();
        }

        public async Task<LeaveSetting> GetbyId(Guid id)
        {
            LeaveSetting leaveSetting = await _leaveSettingRepository.GetAsync(id);
            if (leaveSetting != null)
            {
                await _leaveSettingRepository.EnsurePropertyLoadedAsync(leaveSetting, x => x.EmployeeCard);
                await _leaveSettingRepository.EnsurePropertyLoadedAsync(leaveSetting, x => x.WorkflowSetting);

            }
            return leaveSetting;
        }

        public async Task<LeaveSetting> Insert(LeaveSetting leaveSetting)
        {
           return await _leaveSettingRepository.InsertAsync(leaveSetting);
        }

        public async Task<LeaveSetting> Update(LeaveSetting leaveSetting)
        {
            return await _leaveSettingRepository.UpdateAsync(leaveSetting);

        }
    }
}
