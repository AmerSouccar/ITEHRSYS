using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Services
{
    public interface IAttendanceMonthlyCardDomainService : IDomainService
    {
        public IQueryable<AttendanceMonthlyCard> GetAll();
        public Task<AttendanceMonthlyCard> GetbyId(Guid id);
        public Task<AttendanceMonthlyCard> Insert(AttendanceMonthlyCard attendanceMonthlyCard);
        public Task<AttendanceMonthlyCard> Update(AttendanceMonthlyCard attendanceMonthlyCard);
        public Task Delete(Guid id);

    }
}
