using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto;
using HRSystem.HR.PaginationDto;
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

        public async Task CalculateMonth(Guid id)
        {
            await _monthDomainService.CalculateMonth(id);
        }

        public async Task Delete(Guid id)
        {
            await _monthDomainService.Delete(id);
        }

        public async Task GenerateMonthlyCards(Guid id, List<Guid> employeeIds)
        {
            await _monthDomainService.GenerateMonthlyCards(id, employeeIds);
        }

        public PagedResultDto<ReadMonthDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var months = _monthDomainService.GetAll();
            int total = months.Count();
            months = months.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadMonthDto>>(months.ToList());
            return new PagedResultDto<ReadMonthDto>(total, list);
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
