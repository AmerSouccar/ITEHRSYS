using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Services
{
    public class AttendanceFormDomainService : IAttendanceFormDomainService
    {
        private readonly IRepository<AttendanceForm, Guid> _attendanceFormRepository;

        public AttendanceFormDomainService(IRepository<AttendanceForm, Guid> attendanceFormRepository)
        {
            _attendanceFormRepository = attendanceFormRepository;
        }

        public async Task Delete(Guid id)
        {
           await _attendanceFormRepository.DeleteAsync(id);
        }

        public async Task<List<AttendanceForm>> GetAll()
        {
            return _attendanceFormRepository.GetAllIncluding(x => x.Workshops).ToList();
        }

        public async Task<AttendanceForm> GetbyId(Guid id)
        {
            AttendanceForm attendanceForm = await _attendanceFormRepository.GetAsync(id);
            if(attendanceForm != null)
            {
                await _attendanceFormRepository.EnsureCollectionLoadedAsync(attendanceForm, x => x.Workshops);
            }
            return attendanceForm;
        }

        public async Task<AttendanceForm> Insert(AttendanceForm attendanceForm)
        {
            return await _attendanceFormRepository.InsertAsync(attendanceForm);
        }

        public async Task<AttendanceForm> Update(AttendanceForm attendanceForm)
        {
            return await _attendanceFormRepository.UpdateAsync(attendanceForm);
        }
    }
}
