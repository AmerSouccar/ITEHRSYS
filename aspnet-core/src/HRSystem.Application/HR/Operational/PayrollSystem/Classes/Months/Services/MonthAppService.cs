using HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Services
{
    public class MonthAppService : HRSystemAppServiceBase, IMonthAppService
    {
        private readonly IMonthDomainService _monthDomainService;

        public MonthAppService(IMonthDomainService monthDomainService)
        {
            _monthDomainService = monthDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _monthDomainService.Delete(id);
        }

        public async Task<List<ReadMonthDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadMonthDto>>(await _monthDomainService.GetAll());
        }

        public async Task<ReadMonthDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadMonthDto>(await _monthDomainService.GetbyId(id));
        }

        public async Task<InsertMonthDto> Insert(InsertMonthDto month)
        {
            return ObjectMapper.Map<InsertMonthDto>(await _monthDomainService.Insert(ObjectMapper.Map<Month>(month)));
        }

        public async Task<UpdateMonthDto> Update(UpdateMonthDto month)
        {
            return ObjectMapper.Map<UpdateMonthDto>(await _monthDomainService.Update(ObjectMapper.Map<Month>(month)));
 
        }
    }
}
