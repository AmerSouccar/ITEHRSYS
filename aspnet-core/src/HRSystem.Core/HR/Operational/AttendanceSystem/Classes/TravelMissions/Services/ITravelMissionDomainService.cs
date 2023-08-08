using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Services
{
    public interface ITravelMissionDomainService :IDomainService
    {
        public Task<List<TravelMission>> GetAll();
        public Task<TravelMission> GetbyId(Guid id);
        public Task<TravelMission> Insert(TravelMission travelMission);
        public Task<TravelMission> Update(TravelMission travelMission);
        public Task Delete(Guid id);
    }
}
