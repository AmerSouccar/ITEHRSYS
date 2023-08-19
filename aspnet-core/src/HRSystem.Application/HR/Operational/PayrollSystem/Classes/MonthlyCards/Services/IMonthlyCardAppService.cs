using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Services
{
    public interface IMonthlyCardAppService :IApplicationService
    {
        public PagedResultDto<ReadMonthlyCardDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadMonthlyCardDto> GetbyId(Guid id);
        public Task<InsertMonthlyCardDto> Insert(InsertMonthlyCardDto monthlyCard);
        public Task<UpdateMonthlyCardDto> Update(UpdateMonthlyCardDto monthlyCard);
        public Task Delete(Guid id);
    }
}
