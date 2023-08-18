using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services
{
    public class FixedHolidayAppService : HRSystemAppServiceBase, IFixedHolidayAppService
    {
        private readonly IFixedHolidayDomainService _fixedHolidaydomainService;

        public FixedHolidayAppService(IFixedHolidayDomainService fixedHolidaydomainService)
        {
            _fixedHolidaydomainService = fixedHolidaydomainService;
        }

        public async Task Delete(Guid id)
        {
            await _fixedHolidaydomainService.Delete(id);
        }

        public PagedResultDto<ReadFixedHolidayDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var holidays = _fixedHolidaydomainService.GetAll();
            int total = holidays.Count();
            holidays = holidays.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadFixedHolidayDto>>(holidays.ToList());
            return new PagedResultDto<ReadFixedHolidayDto>(total, list);
        }

        public async Task<ReadFixedHolidayDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadFixedHolidayDto>(await _fixedHolidaydomainService.GetbyId(id));
        }

        public async Task<UpdateFixedHolidayDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateFixedHolidayDto>(await _fixedHolidaydomainService.GetbyId(id));
        }

        public async Task<InsertFixedHolidayDto> Insert(InsertFixedHolidayDto fixedHoliday)
        {
            return ObjectMapper.Map<InsertFixedHolidayDto>(await _fixedHolidaydomainService.Insert(ObjectMapper.Map<FixedHoliday>(fixedHoliday)));
        }

        public async Task<UpdateFixedHolidayDto> Update(UpdateFixedHolidayDto fixedHoliday)
        {
            return ObjectMapper.Map<UpdateFixedHolidayDto>(await _fixedHolidaydomainService.Update(ObjectMapper.Map<FixedHoliday>(fixedHoliday)));

        }
    }
}
