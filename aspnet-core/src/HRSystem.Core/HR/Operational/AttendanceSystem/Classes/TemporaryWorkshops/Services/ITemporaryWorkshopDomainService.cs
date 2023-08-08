using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Services
{
    public interface ITemporaryWorkshopDomainService :IDomainService
    {
        public Task<List<TemporaryWorkshop>> GetAll();
        public Task<TemporaryWorkshop> GetbyId(Guid id);
        public Task<TemporaryWorkshop> Insert(TemporaryWorkshop temporaryWorkshop);
        public Task<TemporaryWorkshop> Update(TemporaryWorkshop temporaryWorkshop);
        public Task Delete(Guid id);
    }
}
