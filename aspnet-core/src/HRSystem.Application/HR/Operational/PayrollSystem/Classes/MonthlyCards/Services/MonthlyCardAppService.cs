using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Services
{
    public class MonthlyCardAppService : HRSystemAppServiceBase, IMonthlyCardAppService
    {
        private readonly IMonthlyCardDominService _monthlyCardDominService;

        public MonthlyCardAppService(IMonthlyCardDominService monthlyCardDominService)
        {
            _monthlyCardDominService = monthlyCardDominService;
        }

        public async Task Delete(Guid id)
        {
            await _monthlyCardDominService.Delete(id);
        }

        public PagedResultDto<ReadMonthlyCardDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var monthlyCards = _monthlyCardDominService.GetAll();
            int total = monthlyCards.Count();
            monthlyCards = monthlyCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadMonthlyCardDto>>(monthlyCards.ToList());
            return new PagedResultDto<ReadMonthlyCardDto>(total, list);
        }

        public PagedResultDto<ReadMonthlyCardDto> GetAllbyId(Guid id,PagedGeneralResultRequestDto input)
        {
            var monthlyCards = _monthlyCardDominService.GetAllbyId(id);
            int total = monthlyCards.Count();
            monthlyCards = monthlyCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadMonthlyCardDto>>(monthlyCards.ToList());
            return new PagedResultDto<ReadMonthlyCardDto>(total, list);
        }

        public async Task<ReadMonthlyCardDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadMonthlyCardDto>(await _monthlyCardDominService.GetbyId(id));
        }

        public async Task<InsertMonthlyCardDto> Insert(InsertMonthlyCardDto monthlyCard)
        {
            return ObjectMapper.Map<InsertMonthlyCardDto>(await _monthlyCardDominService.Insert (ObjectMapper.Map<MonthlyCard>(monthlyCard)));
        }

        public async Task<UpdateMonthlyCardDto> Update(UpdateMonthlyCardDto monthlyCard)
        {
            return ObjectMapper.Map<UpdateMonthlyCardDto>(await _monthlyCardDominService.Update(ObjectMapper.Map<MonthlyCard>(monthlyCard)));

        }
    }
}
