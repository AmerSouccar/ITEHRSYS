using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Services
{
    public interface IAttendanceFormAppService :IApplicationService
    {
        public Task<List<ReadAttendanceFormDto>> GetAll();
        public Task<ReadAttendanceFormDto> GetbyId(Guid id);
        public Task<InsertAttendanceFormDto> Insert(InsertAttendanceFormDto attendanceForm);
        public Task<UpdateAttendanceFormDto> Update(UpdateAttendanceFormDto attendanceForm);
        public Task Delete(Guid id);
    }
}
