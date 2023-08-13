using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Services
{
    public interface IAttendanceRecordDomainService :IDomainService
    {
        public IQueryable <AttendanceRecord> GetAll();
        public Task<AttendanceRecord> GetbyId(Guid id);
        public Task<AttendanceRecord> Insert(AttendanceRecord attendanceRecord);
        public Task<AttendanceRecord> Update(AttendanceRecord attendanceRecord);
        public Task Delete(Guid id);
        public Task GenerateMonthlyCards(Guid id,List<Guid> employeeIds);
        public Task CalculateMonth(Guid id);
    }
}
