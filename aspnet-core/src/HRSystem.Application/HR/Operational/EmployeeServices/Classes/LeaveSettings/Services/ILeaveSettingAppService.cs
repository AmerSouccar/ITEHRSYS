using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Services
{
    public interface ILeaveSettingAppService : IApplicationService
    {
        public PagedResultDto<ReadLeaveSettingDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadLeaveSettingDto> GetbyId(Guid id);
        public Task<UpdateLeaveSettingDto> GetForEdit(Guid id);
        public Task<InsertLeaveSettingDto> Insert(InsertLeaveSettingDto leaveSetting);
        public Task<UpdateLeaveSettingDto> Update(UpdateLeaveSettingDto leaveSetting);
        public Task Delete(Guid id);
    }
}
