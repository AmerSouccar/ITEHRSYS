using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Services
{
    public class AttendanceRecordDomainService : IAttendanceRecordDomainService
    {
        private readonly IRepository<AttendanceRecord,Guid>  _attendanceRecordRepository;

        public AttendanceRecordDomainService(IRepository<AttendanceRecord, Guid> attendanceRecordRepository)
        {
            _attendanceRecordRepository = attendanceRecordRepository;
        }

        public async Task Delete(Guid id)
        {
            await _attendanceRecordRepository.DeleteAsync(id);
        }

        public async Task<List<AttendanceRecord>> GetAll()
        {
            return _attendanceRecordRepository.GetAllIncluding(x => x.AttendanceMonthlyCards).ToList();
        }

        public async Task<AttendanceRecord> GetbyId(Guid id)
        {
            AttendanceRecord attendanceRecord = await _attendanceRecordRepository.GetAsync(id);
            if (attendanceRecord != null)
            {
                await _attendanceRecordRepository.EnsureCollectionLoadedAsync(attendanceRecord, x => x.AttendanceMonthlyCards);
            }
            return attendanceRecord;
        }

        public async Task<AttendanceRecord> Insert(AttendanceRecord attendanceRecord)
        {
            return await _attendanceRecordRepository.InsertAsync(attendanceRecord);
        }

        public async Task<AttendanceRecord> Update(AttendanceRecord attendanceRecord)
        {
            return await _attendanceRecordRepository.UpdateAsync(attendanceRecord);
        }
    }
}
