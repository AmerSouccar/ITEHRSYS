using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadBankDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var banks = _bankDomainService.GetAll();
            int total = banks.Count();
            banks = banks.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadBankDto>>(banks.ToList());
            return new PagedResultDto<ReadBankDto>(total, list);
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
