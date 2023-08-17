using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using HRSystem.HR.PaginationDto;
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

        public async Task AcceptLeaveRequest(Guid id)
        {
            await _leaveRequestDomanService.AcceptLeaveRequest(id);
        }

        public async Task Delete(Guid id)
        {
           await _leaveRequestDomanService.Delete(id);
        }

        public PagedResultDto<ReadLeaveRequestDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var holidays = _leaveRequestDomanService.GetAll();
            int total = holidays.Count();
            holidays = holidays.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadLeaveRequestDto>>(holidays.ToList());
            return new PagedResultDto<ReadLeaveRequestDto>(total, list);
        }

        public async Task<ReadLeaveRequestDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadLeaveRequestDto>(await _leaveRequestDomanService.GetbyId(id));
        }

        public async Task<InsertLeaveRequestDto> Insert(InsertLeaveRequestDto leaveRequest)
        {
            return ObjectMapper.Map<InsertLeaveRequestDto>(await _leaveRequestDomanService.Insert(ObjectMapper.Map<LeaveRequest>(leaveRequest)));
        }

        public async Task RejectLeaveRequest(Guid id)
        {
            await _leaveRequestDomanService.RejectLeaveRequest(id);
        }

        public async Task<UpdateLeaveRequestDto> Update(UpdateLeaveRequestDto leaveRequest)
        {
            return ObjectMapper.Map<UpdateLeaveRequestDto>(await _leaveRequestDomanService.Update(ObjectMapper.Map<LeaveRequest>(leaveRequest)));

        }
    }
}
