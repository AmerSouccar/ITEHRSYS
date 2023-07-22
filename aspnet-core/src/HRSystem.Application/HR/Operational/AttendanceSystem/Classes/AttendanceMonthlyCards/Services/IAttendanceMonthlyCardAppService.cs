using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Services
{
    public interface IAttendanceMonthlyCardAppService : IApplicationService
    {
        public Task<List<ReadAttendanceMonthlyCardDto>> GetAll();
        public Task<ReadAttendanceMonthlyCardDto> GetbyId(Guid id);
        public Task<InsertAttendanceMonthlyCardDto> Insert(InsertAttendanceMonthlyCardDto attendanceMonthlyCard);
        public Task<UpdateAttendanceMonthlyCardDto> Update(UpdateAttendanceMonthlyCardDto attendanceMonthlyCard);
        public Task Delete(Guid id);
    }
}
