using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Services
{
    public class AttendanceMonthlyCardAppService : HRSystemAppServiceBase, IAttendanceMonthlyCardAppService
    {
        private readonly IAttendanceMonthlyCardDomainService _attendanceMonthlyCard;

        public AttendanceMonthlyCardAppService(IAttendanceMonthlyCardDomainService attendanceMonthlyCard)
        {
            _attendanceMonthlyCard = attendanceMonthlyCard;
        }

        public async Task Delete(Guid id)
        {
            await _attendanceMonthlyCard.Delete(id);
        }

        public PagedResultDto<ReadAttendanceMonthlyCardDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var attendanceMonthlyCards = _attendanceMonthlyCard.GetAll();
            int total = attendanceMonthlyCards.Count();
            attendanceMonthlyCards = attendanceMonthlyCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadAttendanceMonthlyCardDto>>(attendanceMonthlyCards.ToList());
            return new PagedResultDto<ReadAttendanceMonthlyCardDto>(total, list);
        }

        public PagedResultDto<ReadAttendanceMonthlyCardDto> GetAllbyId(Guid id, PagedGeneralResultRequestDto input)
        {
            var attendanceMonthlyCards = _attendanceMonthlyCard.GetAllbyId(id);
            int total = attendanceMonthlyCards.Count();
            attendanceMonthlyCards = attendanceMonthlyCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadAttendanceMonthlyCardDto>>(attendanceMonthlyCards.ToList());
            return new PagedResultDto<ReadAttendanceMonthlyCardDto>(total, list);
        }

        public async Task<ReadAttendanceMonthlyCardDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadAttendanceMonthlyCardDto>(await _attendanceMonthlyCard.GetbyId(id));
        }

        public async Task<InsertAttendanceMonthlyCardDto> Insert(InsertAttendanceMonthlyCardDto attendanceMonthlyCard)
        {
            return ObjectMapper.Map<InsertAttendanceMonthlyCardDto>(await _attendanceMonthlyCard.Insert(ObjectMapper.Map<AttendanceMonthlyCard>(attendanceMonthlyCard)));
        }

        public async Task<UpdateAttendanceMonthlyCardDto> Update(UpdateAttendanceMonthlyCardDto attendanceMonthlyCard)
        {
            return ObjectMapper.Map<UpdateAttendanceMonthlyCardDto>(await _attendanceMonthlyCard.Update(ObjectMapper.Map<AttendanceMonthlyCard>(attendanceMonthlyCard)));

        }
    }
}
