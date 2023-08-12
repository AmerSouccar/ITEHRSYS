using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadAttendanceFormDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var attendanceForms = _attendanceForm.GetAll();
            int total = attendanceForms.Count();
            attendanceForms = attendanceForms.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadAttendanceFormDto>>(attendanceForms.ToList());
            return new PagedResultDto<ReadAttendanceFormDto>(total, list);
        }

        public async Task<ReadAttendanceFormDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadAttendanceFormDto>(await _attendanceForm.GetbyId(id));
        }

        public async Task<UpdateAttendanceFormDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateAttendanceFormDto>(await _attendanceForm.GetbyId(id));
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
