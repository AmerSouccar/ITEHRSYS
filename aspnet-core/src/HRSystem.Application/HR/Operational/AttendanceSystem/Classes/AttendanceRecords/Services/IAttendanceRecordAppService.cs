using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Services
{
    public interface IAttendanceRecordAppService : IApplicationService
    {
        public Task<List<ReadAttendanceRecordDto>> GetAll();
        public Task<ReadAttendanceRecordDto> GetbyId(Guid id);
        public Task<InsertAttendanceRecordDto> Insert(InsertAttendanceRecordDto attendanceRecord);
        public Task<UpdateAttendanceRecordDto> Update(UpdateAttendanceRecordDto attendanceRecord);
        public Task Delete(Guid id);
        public Task GenerateMonthlyCards(Guid id, List<Guid> employeeCardsIds);
        public Task CalculateMonth(Guid id);

    }
}
