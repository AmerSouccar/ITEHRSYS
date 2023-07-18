using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Services
{
    public class LeaveRequestDomanService : ILeaveRequestDomanService
    {
        private readonly IRepository<LeaveRequest,Guid> _leaveRequestsRepository;

        public LeaveRequestDomanService(IRepository<LeaveRequest, Guid> leaveRequestsRepository)
        {
            _leaveRequestsRepository = leaveRequestsRepository;
        }

        public async Task Delete(Guid id)
        {
            await _leaveRequestsRepository.DeleteAsync(id);
        }

        public async Task<List<LeaveRequest>> GetAll()
        {
            return _leaveRequestsRepository.GetAllIncluding(x => x.LeaveSetting).ToList();
        }

        public async Task<LeaveRequest> GetbyId(Guid id)
        {
            LeaveRequest leaveRequest = await _leaveRequestsRepository.GetAsync(id);
            if (leaveRequest != null)
            {
                await _leaveRequestsRepository.EnsurePropertyLoadedAsync(leaveRequest, x => x.LeaveSetting);
            }
            return leaveRequest;
        }

        public async Task<LeaveRequest> Insert(LeaveRequest leaveRequest)
        {
            return await _leaveRequestsRepository.InsertAsync(leaveRequest);

        }

        public async Task<LeaveRequest> Update(LeaveRequest leaveRequest)
        {
            return await _leaveRequestsRepository.UpdateAsync(leaveRequest);

        }
    }
}
