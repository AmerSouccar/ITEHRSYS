using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services
{
    public interface ILeaveRequestAppService : IApplicationService
    {
        public PagedResultDto<ReadLeaveRequestDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadLeaveRequestDto> GetbyId(Guid id);
        public Task AcceptLeaveRequest(Guid id);
        public Task RejectLeaveRequest(Guid id);
        public Task<InsertLeaveRequestDto> Insert(InsertLeaveRequestDto leaveRequest);
        public Task<UpdateLeaveRequestDto> Update(UpdateLeaveRequestDto leaveRequest);
        public Task Delete(Guid id);
    }
}
