using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto;
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

        public async Task<List<ReadFixedHolidayDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadFixedHolidayDto>>(await _fixedHolidaydomainService.GetAll());
        }

        public async Task<ReadFixedHolidayDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadFixedHolidayDto>(await _fixedHolidaydomainService.GetbyId(id));
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
