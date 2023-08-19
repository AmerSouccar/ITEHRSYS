using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Services
{
    public interface IFinancialCardAppService : IApplicationService
    {
        public PagedResultDto<ReadFinancialCardDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadFinancialCardDto> GetbyId(Guid id);
        public Task<UpdateFinancialCardDto> GetForEdit(Guid id);
        public Task<InsertFinancialCardDto> Insert(InsertFinancialCardDto financialCard);
        public Task<UpdateFinancialCardDto> Update(UpdateFinancialCardDto financialCard);
        public Task Delete(Guid id);
    }
}
