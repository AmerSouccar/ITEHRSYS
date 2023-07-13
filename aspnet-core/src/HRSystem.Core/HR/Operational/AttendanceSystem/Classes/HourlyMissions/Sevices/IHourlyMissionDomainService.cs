using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Sevices
{
    public interface IHourlyMissionDomainService : IDomainService
    {
        public Task<List<HourlyMission>> GetAll();
        public Task<HourlyMission> GetbyId(Guid id);
        public Task<HourlyMission> Insert(HourlyMission hourlyMission);
        public Task<HourlyMission> Update(HourlyMission hourlyMission);
        public Task Delete(Guid id);
    }
}
