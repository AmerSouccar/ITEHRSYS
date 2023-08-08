using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Services
{
    public class AttendanceRecordAppService : HRSystemAppServiceBase, IAttendanceRecordAppService
    {
        private readonly IAttendanceRecordDomainService _attendanceRecord;

        public AttendanceRecordAppService(IAttendanceRecordDomainService attendanceRecord)
        {
            _attendanceRecord = attendanceRecord;
        }

        public async Task CalculateMonth(Guid id)
        {
            await _attendanceRecord.CalculateMonth(id);
        }

        public async Task Delete(Guid id)
        {
            await _attendanceRecord.Delete(id);
        }

        public async Task GenerateMonthlyCards(Guid id, List<Guid> employeeCardsIds)
        {
            await _attendanceRecord.GenerateMonthlyCards(id,employeeCardsIds);
        }

        public async Task<List<ReadAttendanceRecordDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadAttendanceRecordDto>>(await _attendanceRecord.GetAll());
        }

        public async Task<ReadAttendanceRecordDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadAttendanceRecordDto>(await _attendanceRecord.GetbyId(id));
        }

        public async Task<InsertAttendanceRecordDto> Insert(InsertAttendanceRecordDto attendanceRecord)
        {
            return ObjectMapper.Map<InsertAttendanceRecordDto>(await _attendanceRecord.Insert(ObjectMapper.Map<AttendanceRecord>(attendanceRecord)));
        }

        public async Task<UpdateAttendanceRecordDto> Update(UpdateAttendanceRecordDto attendanceRecord)
        {
            return ObjectMapper.Map<UpdateAttendanceRecordDto>(await _attendanceRecord.Update(ObjectMapper.Map<AttendanceRecord>(attendanceRecord)));

        }
    }
}
