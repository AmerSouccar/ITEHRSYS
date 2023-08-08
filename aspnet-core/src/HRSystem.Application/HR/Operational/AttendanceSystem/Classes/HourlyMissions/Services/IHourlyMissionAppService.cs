using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Services
{
    public interface IHourlyMissionAppService :IApplicationService
    {
        public Task<List<ReadHourlyMissionDto>> GetAll();
        public Task<ReadHourlyMissionDto> GetbyId(Guid id);
        public Task<InsertHourlyMissionDto> Insert(InsertHourlyMissionDto hourlyMission);
        public Task<UpdateHourlyMissionDto> Update(UpdateHourlyMissionDto hourlyMission);
        public Task Delete(Guid id);
    }
}
