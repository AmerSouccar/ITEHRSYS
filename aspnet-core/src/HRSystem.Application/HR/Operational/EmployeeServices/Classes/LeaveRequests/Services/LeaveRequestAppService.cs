using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services
{
    public class LeaveRequestAppService : HRSystemAppServiceBase, ILeaveRequestAppService
    {
        private readonly ILeaveRequestDomanService _leaveRequestDomanService;

        public LeaveRequestAppService(ILeaveRequestDomanService leaveRequestDomanService)
        {
            _leaveRequestDomanService = leaveRequestDomanService;
        }

        public async Task Delete(Guid id)
        {
           await _leaveRequestDomanService.Delete(id);
        }

        public async Task<List<ReadLeaveRequestDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadLeaveRequestDto>>(await _leaveRequestDomanService.GetAll());
        }

        public async Task<ReadLeaveRequestDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadLeaveRequestDto>(await _leaveRequestDomanService.GetbyId(id));
        }

        public async Task<InsertLeaveRequestDto> Insert(InsertLeaveRequestDto leaveRequest)
        {
            return ObjectMapper.Map<InsertLeaveRequestDto>(await _leaveRequestDomanService.Insert(ObjectMapper.Map<LeaveRequest>(leaveRequest)));
        }

        public async Task<UpdateLeaveRequestDto> Update(UpdateLeaveRequestDto leaveRequest)
        {
            return ObjectMapper.Map<UpdateLeaveRequestDto>(await _leaveRequestDomanService.Update(ObjectMapper.Map<LeaveRequest>(leaveRequest)));

        }
    }
}
