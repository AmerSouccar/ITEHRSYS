using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using HRSystem.HR.Operational.Workflows.Classes.Workflow;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings;
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
        private readonly IRepository<Employee,Guid> _employeeRepository;
        private readonly IRepository<Workflow,Guid> _workflowRepository;
        private readonly IRepository<WorkflowSetting,Guid> _workflowSettingsRepository;
        private readonly IRepository<EmployeeCard,Guid> _employeeCardRepository;
        private readonly IRepository<LeaveSetting,Guid> _leaveSettingRepository;
        private readonly IAbpSession abpSession;
        public LeaveRequestDomanService(IRepository<LeaveRequest, Guid> leaveRequestsRepository, IAbpSession abpSession, IRepository<Workflow, Guid> workflowRepository, IRepository<Employee, Guid> employeeRepository, IRepository<EmployeeCard, Guid> employeeCardRepository, IRepository<LeaveSetting, Guid> leaveSettingRepository, IRepository<WorkflowSetting, Guid> workflowSettingsRepository)
        {
            _leaveRequestsRepository = leaveRequestsRepository;
            this.abpSession = abpSession;
            _workflowRepository = workflowRepository;
            _employeeRepository = employeeRepository;
            _employeeCardRepository = employeeCardRepository;
            _leaveSettingRepository = leaveSettingRepository;
            _workflowSettingsRepository = workflowSettingsRepository;
        }

        public async Task AcceptLeaveRequest(Guid id)
        {
            var leaveRequest = await _leaveRequestsRepository.GetAsync(id);
            var workflow = await _workflowRepository.FirstOrDefaultAsync(x => x.RequiredTypeId == leaveRequest.Id && x.Status == Workflows.Enums.WorkflowStatus.Pending);
            if(workflow.TargetUserId == abpSession.GetUserId())
            {
                leaveRequest.LeaveRequestStatus = Enums.LeaveRequestStatus.Accepted;
                await _leaveRequestsRepository.UpdateAsync(leaveRequest);
                workflow.Status = Workflows.Enums.WorkflowStatus.Completed;
                await _workflowRepository.UpdateAsync(workflow);

            }
            else
            {
                workflow.CurrentUserId = workflow.TargetUserId;
                await _workflowRepository.UpdateAsync(workflow);
            }
        }

        public async Task RejectLeaveRequest(Guid id)
        {
            var leaveRequest = await _leaveRequestsRepository.GetAsync(id);
            var workflow = await _workflowRepository.FirstOrDefaultAsync(x => x.RequiredTypeId == leaveRequest.Id && x.Status == Workflows.Enums.WorkflowStatus.Pending);
    
                leaveRequest.LeaveRequestStatus = Enums.LeaveRequestStatus.Rejected;
                await _leaveRequestsRepository.UpdateAsync(leaveRequest);
                workflow.Status = Workflows.Enums.WorkflowStatus.Rejected;
                workflow.CurrentUserId = workflow.TargetUserId;
                await _workflowRepository.UpdateAsync(workflow);
        }

        public async Task Delete(Guid id)
        {
            await _leaveRequestsRepository.DeleteAsync(id);
        }

        public IQueryable<LeaveRequest> GetAll()
        {
            return _leaveRequestsRepository.GetAllIncluding(x => x.LeaveSetting,x => x.Employee);
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
            if (leaveRequest.EndHour < leaveRequest.StartHour)
                leaveRequest.EndDate.AddDays(1);
            leaveRequest.LeaveRequestStatus = Enums.LeaveRequestStatus.Accepted;
            return await _leaveRequestsRepository.InsertAsync(leaveRequest);

        }
        public async Task<LeaveRequest> Update(LeaveRequest leaveRequest)
        {
            if (leaveRequest.EndHour < leaveRequest.StartHour)
                leaveRequest.EndDate.AddDays(1);
            leaveRequest.LeaveRequestStatus = Enums.LeaveRequestStatus.Accepted;
            return await _leaveRequestsRepository.UpdateAsync(leaveRequest);

        }

        public async Task RequestLeave(LeaveRequest leaveRequest)
        {
            var leaveID = await _leaveRequestsRepository.InsertAndGetIdAsync(leaveRequest);
            long userId = abpSession.GetUserId();
            var emp = await _employeeRepository.FirstOrDefaultAsync(x => x.UserId == userId);
            leaveRequest.Employee = emp;
            leaveRequest.EmployeeId = emp.Id;
            var empCard = await _employeeCardRepository.FirstOrDefaultAsync(x => x.EmployeeId == emp.Id);
            await _employeeCardRepository.EnsurePropertyLoadedAsync(empCard, x => x.Position);
            var leaveSettings = await _leaveSettingRepository.GetAsync(leaveRequest.LeaveSettingId);
            var workflowSettings = await _workflowSettingsRepository.GetAsync(leaveSettings.WorkflowSettingId);
            Guid? firstUserId = Guid.Empty;
            Guid? targetUserId = Guid.Empty;
            for (int i = 0; i < workflowSettings.Steps; i++)
            {
                Guid uID = Guid.Empty;
                if(empCard.Position.ManagerId == Guid.Empty)
                {
                    if(firstUserId == Guid.Empty)
                    {
                        leaveRequest.LeaveRequestStatus = Enums.LeaveRequestStatus.Accepted;
                    }
                    break;
                }
                if(firstUserId == Guid.Empty)
                {
                    firstUserId = empCard.Position.ManagerId;
                }
                else
                {
                    targetUserId = empCard.Position.ManagerId;
                }
            }
            if(firstUserId != Guid.Empty && targetUserId != Guid.Empty)
            {
                var fUID = await _employeeRepository.FirstOrDefaultAsync(x => x.Id == firstUserId);
                var tUID = await _employeeRepository.FirstOrDefaultAsync(x => x.Id == targetUserId);
                Workflow workflow = new Workflow()
                {
                    CreatorId = emp.UserId,
                    FirstUserId = fUID.UserId,
                    CurrentUserId = fUID.UserId,
                    TargetUserId = tUID.UserId,
                    Status = Workflows.Enums.WorkflowStatus.Pending,
                    Type = Workflows.Enums.WorkflowType.Leave,
                    RequiredTypeId = leaveID,
                };
                await _workflowRepository.InsertAsync(workflow);
            }
           
        }

        public IQueryable<LeaveRequest> GetMyEmployeesLeaveRequests()
        {
            var workflows = _workflowRepository.GetAll().Where(x => x.CurrentUserId == abpSession.GetUserId() && x.Status == Workflows.Enums.WorkflowStatus.Pending);
            List<LeaveRequest> leaveRequests = new List<LeaveRequest>();
            foreach(var workflow in workflows)
            {
                var l = _leaveRequestsRepository.Get(workflow.RequiredTypeId);
                leaveRequests.Add(l);
            }
            return leaveRequests.AsQueryable();
        }
    }
}
