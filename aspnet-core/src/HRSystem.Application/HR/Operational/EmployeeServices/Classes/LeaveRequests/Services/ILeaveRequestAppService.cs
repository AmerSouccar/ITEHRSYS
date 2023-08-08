using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services
{
    public interface ILeaveRequestAppService : IApplicationService
    {
        public Task<List<ReadLeaveRequestDto>> GetAll();
        public Task<ReadLeaveRequestDto> GetbyId(Guid id);
        public Task<InsertLeaveRequestDto> Insert(InsertLeaveRequestDto leaveRequest);
        public Task<UpdateLeaveRequestDto> Update(UpdateLeaveRequestDto leaveRequest);
        public Task Delete(Guid id);
    }
}
