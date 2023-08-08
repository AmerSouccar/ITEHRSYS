using Abp.Application.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Services
{
    public interface IFinancialCardAppService : IApplicationService
    {
        public Task<List<ReadFinancialCardDto>> GetAll();
        public Task<ReadFinancialCardDto> GetbyId(Guid id);
        public Task<InsertFinancialCardDto> Insert(InsertFinancialCardDto financialCard);
        public Task<UpdateFinancialCardDto> Update(UpdateFinancialCardDto financialCard);
        public Task Delete(Guid id);
    }
}
