using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Services
{
    public interface IAttendanceFormDomainService : IDomainService
    {
        public Task<List<AttendanceForm>> GetAll();
        public Task<AttendanceForm> GetbyId(Guid id);
        public Task<AttendanceForm> Insert(AttendanceForm attendanceForm);
        public Task<AttendanceForm> Update(AttendanceForm attendanceForm);
        public Task Delete(Guid id);
    }
}
