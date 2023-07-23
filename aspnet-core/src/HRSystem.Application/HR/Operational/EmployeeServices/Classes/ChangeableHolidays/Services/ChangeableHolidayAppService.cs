using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Services
{
    public class ChangeableHolidayAppService : HRSystemAppServiceBase, IChangeableHolidayAppService
    {
        private readonly IChangeableHolidayDomainService _changeableHolidaydomainService;

        public ChangeableHolidayAppService(IChangeableHolidayDomainService changeableHolidaydomainService)
        {
            _changeableHolidaydomainService = changeableHolidaydomainService;
        }

        public async Task Delete(Guid id)
        {
            await _changeableHolidaydomainService.Delete(id);
        }

        public async Task<List<ReadChangeableHolidayDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadChangeableHolidayDto>>(await _changeableHolidaydomainService.GetAll());
        }

        public async Task<ReadChangeableHolidayDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadChangeableHolidayDto>(await _changeableHolidaydomainService.GetbyId(id));
        }

        public async Task<InsertChangeableHolidayDto> Insert(InsertChangeableHolidayDto changeableHoliday)
        {
            return ObjectMapper.Map<InsertChangeableHolidayDto>(await _changeableHolidaydomainService.Insert(ObjectMapper.Map<ChangeableHoliday>(changeableHoliday)));
        }

        public async Task<UpdateChangeableHolidayDto> Update(UpdateChangeableHolidayDto changeableHoliday)
        {
            return ObjectMapper.Map<UpdateChangeableHolidayDto>(await _changeableHolidaydomainService.Update(ObjectMapper.Map<ChangeableHoliday>(changeableHoliday)));

        }
    }
}
