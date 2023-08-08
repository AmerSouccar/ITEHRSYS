using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Services
{
    public interface ITravelMissionAppService :IApplicationService
    {
        public Task<List<ReadTravelMissionDto>> GetAll();
        public Task<ReadTravelMissionDto> GetbyId(Guid id);
        public Task<InsertTravelMissionDto> Insert(InsertTravelMissionDto travelMission);
        public Task<UpdateTravelMissionDto> Update(UpdateTravelMissionDto travelMission);
        public Task Delete(Guid id);
    }
}
