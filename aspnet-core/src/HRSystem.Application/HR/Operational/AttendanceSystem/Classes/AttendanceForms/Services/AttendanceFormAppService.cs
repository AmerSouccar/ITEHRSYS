using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Services
{
    public class AttendanceFormAppService : HRSystemAppServiceBase, IAttendanceFormAppService
    {
        private readonly IAttendanceFormDomainService _attendanceForm;

        public AttendanceFormAppService(IAttendanceFormDomainService attendanceForm)
        {
            _attendanceForm = attendanceForm;
        }

        public async Task Delete(Guid id)
        {
            await _attendanceForm.Delete(id);
        }

        public async Task<List<ReadAttendanceFormDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadAttendanceFormDto>>(await _attendanceForm.GetAll());
        }

        public async Task<ReadAttendanceFormDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadAttendanceFormDto>(await _attendanceForm.GetbyId(id));
        }

        public async Task<InsertAttendanceFormDto> Insert(InsertAttendanceFormDto attendanceForm)
        {
            return ObjectMapper.Map<InsertAttendanceFormDto>(await _attendanceForm.Insert(ObjectMapper.Map<AttendanceForm>(attendanceForm)));
        }

        public async Task<UpdateAttendanceFormDto> Update(UpdateAttendanceFormDto attendanceForm)
        {
            return ObjectMapper.Map<UpdateAttendanceFormDto>(await _attendanceForm.Update(ObjectMapper.Map<AttendanceForm>(attendanceForm)));

        }
    }
}
