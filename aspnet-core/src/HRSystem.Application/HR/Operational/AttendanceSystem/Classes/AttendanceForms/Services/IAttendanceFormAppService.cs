using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Services
{
    public interface IAttendanceFormAppService :IApplicationService
    {
        public PagedResultDto<ReadAttendanceFormDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadAttendanceFormDto> GetbyId(Guid id);
        public Task<UpdateAttendanceFormDto> GetForEdit(Guid id);
        public Task<InsertAttendanceFormDto> Insert(InsertAttendanceFormDto attendanceForm);
        public Task<UpdateAttendanceFormDto> Update(UpdateAttendanceFormDto attendanceForm);
        public Task Delete(Guid id);
    }
}
