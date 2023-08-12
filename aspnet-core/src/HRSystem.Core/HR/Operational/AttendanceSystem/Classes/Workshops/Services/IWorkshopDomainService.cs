using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Services
{
    public interface IWorkshopDomainService :IDomainService
    {
        public IQueryable<Workshop> GetAll();
        public Task<Workshop> GetbyId(Guid id);
        public Task<Workshop> Insert(Workshop workshop);
        public Task<Workshop> Update(Workshop workshop);
        public Task Delete(Guid id);
    }
}
