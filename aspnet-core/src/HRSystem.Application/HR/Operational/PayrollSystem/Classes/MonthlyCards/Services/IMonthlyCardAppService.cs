using Abp.Application.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Services
{
    public interface IMonthlyCardAppService :IApplicationService
    {
        public Task<List<ReadMonthlyCardDto>> GetAll();
        public Task<ReadMonthlyCardDto> GetbyId(Guid id);
        public Task<InsertMonthlyCardDto> Insert(InsertMonthlyCardDto monthlyCard);
        public Task<UpdateMonthlyCardDto> Update(UpdateMonthlyCardDto monthlyCard);
        public Task Delete(Guid id);
    }
}
