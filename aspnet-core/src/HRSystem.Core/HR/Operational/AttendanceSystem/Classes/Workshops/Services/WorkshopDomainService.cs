using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Services
{
    public class WorkshopDomainService : IWorkshopDomainService
    {
        private readonly IRepository<Workshop,Guid> _workshopRepository;

        public WorkshopDomainService(IRepository<Workshop, Guid> workshopRepository)
        {
            _workshopRepository = workshopRepository;
        }

        public async Task Delete(Guid id)
        {
            await _workshopRepository.DeleteAsync(id);
        }

        public async Task<List<Workshop>> GetAll()
        {
            return  _workshopRepository.GetAllIncluding(x=>x.NormalShifts).ToList();
        }

        public async Task<Workshop> GetbyId(Guid id)
        {
            Workshop workshop = await _workshopRepository.GetAsync(id);
            if (workshop != null)
            {
                await _workshopRepository.EnsureCollectionLoadedAsync(workshop, x => x.NormalShifts);
            }
            return workshop;
        }

        public async Task<Workshop> Insert(Workshop workshop)
        {
            return await _workshopRepository.InsertAsync(workshop);
        }

        public async Task<Workshop> Update(Workshop workshop)
        {
            return await _workshopRepository.UpdateAsync(workshop);

        }
    }
}
