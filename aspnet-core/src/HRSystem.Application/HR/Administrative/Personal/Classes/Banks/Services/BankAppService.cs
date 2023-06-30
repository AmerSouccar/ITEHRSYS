using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Services
{
    public class BankAppService : HRSystemAppServiceBase, IBankAppService
    {
        private readonly IBankDomainService _bankDomainService;

        public BankAppService(IBankDomainService bankDomainService)
        {
            _bankDomainService = bankDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _bankDomainService.Delete(id);
        }

        public async Task<List<ReadBankDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadBankDto>>(await _bankDomainService.GetAll());
        }

        public async Task<ReadBankDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadBankDto>(await _bankDomainService.GetbyId(id));
        }

        public async Task<InsertBankDto> Insert(InsertBankDto bank)
        {
            return ObjectMapper.Map<InsertBankDto>(await _bankDomainService.Insert(ObjectMapper.Map<Bank>(bank)));
        }

        public async Task<UpdateBankDto> Update(UpdateBankDto bank)
        {
            return ObjectMapper.Map<UpdateBankDto>(await _bankDomainService.Update(ObjectMapper.Map<Bank>(bank)));
        }
    }
}
