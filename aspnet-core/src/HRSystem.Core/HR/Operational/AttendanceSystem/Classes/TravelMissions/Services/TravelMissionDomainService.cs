using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Services
{
    public class TravelMissionDomainService : ITravelMissionDomainService
    {
        private readonly IRepository<TravelMission,Guid> _travelMissionRepository;

        public TravelMissionDomainService(IRepository<TravelMission, Guid> travelMissionRepository)
        {
            _travelMissionRepository = travelMissionRepository;
        }

        public async Task Delete(Guid id)
        {
            await _travelMissionRepository.DeleteAsync(id);
        }

        public IQueryable<TravelMission> GetAll()
        {
            return _travelMissionRepository.GetAllIncluding(x => x.Employee);
        }

        public async Task<TravelMission> GetbyId(Guid id)
        {
            TravelMission travelMission = await _travelMissionRepository.GetAsync(id);
            if (travelMission != null)
            {
                await _travelMissionRepository.EnsurePropertyLoadedAsync(travelMission, x => x.Employee);
            }
            return travelMission;
        }

        public async Task<TravelMission> Insert(TravelMission travelMission)
        {
           return await _travelMissionRepository.InsertAsync(travelMission);
        }

        public async Task<TravelMission> Update(TravelMission travelMission)
        {
            return await _travelMissionRepository.UpdateAsync(travelMission);

        }
    }
}
