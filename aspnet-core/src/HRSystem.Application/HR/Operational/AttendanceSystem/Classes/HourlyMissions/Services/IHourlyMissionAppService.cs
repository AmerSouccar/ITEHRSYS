using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Services
{
    public interface IHourlyMissionAppService :IApplicationService
    {
        public PagedResultDto<ReadHourlyMissionDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadHourlyMissionDto> GetbyId(Guid id);
        public Task<InsertHourlyMissionDto> Insert(InsertHourlyMissionDto hourlyMission);
        public Task<UpdateHourlyMissionDto> Update(UpdateHourlyMissionDto hourlyMission);
        public Task Delete(Guid id);
    }
}
