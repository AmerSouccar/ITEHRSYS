using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Services
{
    public class AttendanceMonthlyCardDomainService : IAttendanceMonthlyCardDomainService
    {
        private readonly IRepository<AttendanceMonthlyCard, Guid> _attendanceMonthlyCardRepository;

        public AttendanceMonthlyCardDomainService(IRepository<AttendanceMonthlyCard, Guid> attendanceMonthlyCardRepository)
        {
            _attendanceMonthlyCardRepository = attendanceMonthlyCardRepository;
        }

        public async Task Delete(Guid id)
        {
            await _attendanceMonthlyCardRepository.DeleteAsync(id);
        }

        public  IQueryable<AttendanceMonthlyCard> GetAll()
        {
            return _attendanceMonthlyCardRepository.GetAllIncluding(x => x.EmployeeCard.Employee);
        }

        public IQueryable<AttendanceMonthlyCard> GetAllbyId(Guid id)
        {
            return _attendanceMonthlyCardRepository.GetAllIncluding(x => x.EmployeeCard.Employee).Where(x => x.AttendanceRecordId == id);
        }

        public async Task<AttendanceMonthlyCard> GetbyId(Guid id)
        {
            AttendanceMonthlyCard attendanceMonthlyCard = await _attendanceMonthlyCardRepository.GetAsync(id);
            if(attendanceMonthlyCard != null)
            {
                await _attendanceMonthlyCardRepository.EnsurePropertyLoadedAsync(attendanceMonthlyCard, x => x.EmployeeCard);
            }
            return attendanceMonthlyCard;
        }

        public async Task<AttendanceMonthlyCard> Insert(AttendanceMonthlyCard attendanceMonthlyCard)
        {
            return await _attendanceMonthlyCardRepository.InsertAsync(attendanceMonthlyCard);
        }

        public async Task<AttendanceMonthlyCard> Update(AttendanceMonthlyCard attendanceMonthlyCard)
        {
            return await _attendanceMonthlyCardRepository.UpdateAsync(attendanceMonthlyCard);
        }
    }
}
