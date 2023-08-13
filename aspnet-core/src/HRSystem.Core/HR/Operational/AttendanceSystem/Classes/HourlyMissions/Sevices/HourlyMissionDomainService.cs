using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Sevices
{
    public class HourlyMissionDomainService : IHourlyMissionDomainService
    {
        private readonly IRepository<HourlyMission,Guid> _hourlyMissionRepository;

        public HourlyMissionDomainService(IRepository<HourlyMission, Guid> hourlyMissionRepository)
        {
            _hourlyMissionRepository = hourlyMissionRepository;
        }

        public async Task Delete(Guid id)
        {
           await _hourlyMissionRepository.DeleteAsync(id);
        }

        public IQueryable<HourlyMission> GetAll()
        {
            return _hourlyMissionRepository.GetAllIncluding(x => x.Employee);
        }

        public async Task<HourlyMission> GetbyId(Guid id)
        {
            HourlyMission hourlyMission = await _hourlyMissionRepository.GetAsync(id);
            if (hourlyMission != null)
            {
                await _hourlyMissionRepository.EnsurePropertyLoadedAsync(hourlyMission, x => x.Employee);
            }
            return hourlyMission;
        }

        public async Task<HourlyMission> Insert(HourlyMission hourlyMission)
        {
            return await _hourlyMissionRepository.InsertAsync(hourlyMission);
        }

        public async Task<HourlyMission> Update(HourlyMission hourlyMission)
        {
            return await _hourlyMissionRepository.UpdateAsync(hourlyMission);

        }
    }
}
