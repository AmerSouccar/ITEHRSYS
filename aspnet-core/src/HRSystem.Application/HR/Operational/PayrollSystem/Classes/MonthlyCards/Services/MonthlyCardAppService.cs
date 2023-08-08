using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
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

        public async Task<List<ReadMonthlyCardDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadMonthlyCardDto>>(await _monthlyCardDominService.GetAll());
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
