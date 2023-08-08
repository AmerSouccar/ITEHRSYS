using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Services
{
    public class TemporaryWorkshopDomainService : ITemporaryWorkshopDomainService
    {
        private readonly IRepository<TemporaryWorkshop,Guid> _temporaryWorkshoprepository;

        public TemporaryWorkshopDomainService(IRepository<TemporaryWorkshop, Guid> temporaryWorkshoprepository)
        {
            _temporaryWorkshoprepository = temporaryWorkshoprepository;
        }

        public async Task Delete(Guid id)
        {
            await _temporaryWorkshoprepository.DeleteAsync(id);
        }

        public async Task<List<TemporaryWorkshop>> GetAll()
        {
            return _temporaryWorkshoprepository.GetAllIncluding(x => x.Workshop, x => x.TempWorkshop).ToList();
        }

        public async Task<TemporaryWorkshop> GetbyId(Guid id)
        {
            TemporaryWorkshop temporaryWorkshop = await _temporaryWorkshoprepository.GetAsync(id);
            if (temporaryWorkshop != null)
            {
                await _temporaryWorkshoprepository.EnsurePropertyLoadedAsync(temporaryWorkshop, x => x.Workshop);
                await _temporaryWorkshoprepository.EnsurePropertyLoadedAsync(temporaryWorkshop, x => x.TempWorkshop);
            }
            return temporaryWorkshop;
        }

        public async Task<TemporaryWorkshop> Insert(TemporaryWorkshop temporaryWorkshop)
        {
            return await _temporaryWorkshoprepository.InsertAsync(temporaryWorkshop);
        }

        public async Task<TemporaryWorkshop> Update(TemporaryWorkshop temporaryWorkshop)
        {
            return await _temporaryWorkshoprepository.UpdateAsync(temporaryWorkshop);

        }
    }
}
