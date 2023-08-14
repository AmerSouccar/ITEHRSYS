using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services
{
    public interface ILeaveRequestDomanService :IDomainService
    {
        public Task<List<LeaveRequest>> GetAll();
        public Task<LeaveRequest> GetbyId(Guid id);
        public Task AcceptLeaveRequest(Guid id);
        public Task RejectLeaveRequest(Guid id);
        public Task<LeaveRequest> Insert(LeaveRequest leaveRequest);
        public Task<LeaveRequest> Update(LeaveRequest leaveRequest);
        public Task Delete(Guid id);
    }
}
