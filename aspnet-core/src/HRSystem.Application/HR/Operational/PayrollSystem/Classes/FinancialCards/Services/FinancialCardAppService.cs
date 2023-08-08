using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards.Services
{
    public class FinancialCardAppService : HRSystemAppServiceBase, IFinancialCardAppService
    {
        private readonly IFinancialCardDomainService _financialCardDomainService;

        public FinancialCardAppService(IFinancialCardDomainService financialCardDomainService)
        {
            _financialCardDomainService = financialCardDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _financialCardDomainService.Delete(id);
        }

        public async Task<List<ReadFinancialCardDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadFinancialCardDto>>(await _financialCardDomainService.GetAll());
        }

        public async Task<ReadFinancialCardDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadFinancialCardDto>(await _financialCardDomainService.GetbyId(id));
        }

        public async Task<InsertFinancialCardDto> Insert(InsertFinancialCardDto financialCard)
        {
            return ObjectMapper.Map<InsertFinancialCardDto>(await _financialCardDomainService.Insert(ObjectMapper.Map<FinancialCard>(financialCard)));
        }

        public async Task<UpdateFinancialCardDto> Update(UpdateFinancialCardDto financialCard)
        {
            return ObjectMapper.Map<UpdateFinancialCardDto>(await _financialCardDomainService.Update(ObjectMapper.Map<FinancialCard>(financialCard)));

        }
    }
}
