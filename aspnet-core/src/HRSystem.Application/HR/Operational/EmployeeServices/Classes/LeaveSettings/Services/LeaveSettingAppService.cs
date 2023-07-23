using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Services
{
    public class LeaveSettingAppService : HRSystemAppServiceBase, ILeaveSettingAppService
    {
        private readonly ILeaveSettingDomainService _leaveSettingDomainService;

        public LeaveSettingAppService(ILeaveSettingDomainService leaveSettingDomainService)
        {
            _leaveSettingDomainService = leaveSettingDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _leaveSettingDomainService.Delete(id);
        }

        public async Task<List<ReadLeaveSettingDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadLeaveSettingDto>>(await _leaveSettingDomainService.GetAll());
        }

        public async Task<ReadLeaveSettingDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadLeaveSettingDto>(await _leaveSettingDomainService.GetbyId(id));
        }

        public async Task<InsertLeaveSettingDto> Insert(InsertLeaveSettingDto leaveSetting)
        {
            return ObjectMapper.Map<InsertLeaveSettingDto>(await _leaveSettingDomainService.Insert(ObjectMapper.Map<LeaveSetting>(leaveSetting)));
        }

        public async Task<UpdateLeaveSettingDto> Update(UpdateLeaveSettingDto leaveSetting)
        {
            return ObjectMapper.Map<UpdateLeaveSettingDto>(await _leaveSettingDomainService.Update(ObjectMapper.Map<LeaveSetting>(leaveSetting)));

        }
    }
}
