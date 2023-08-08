using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Services
{
    public class BankInformationAppService : HRSystemAppServiceBase, IBankInformationAppService
    {
        private readonly IBankInformationDomainService _bankInformationDomainService;

        public BankInformationAppService(IBankInformationDomainService bankInformationDomainService)
        {
            _bankInformationDomainService = bankInformationDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _bankInformationDomainService.Delete(id);
        }

        public PagedResultDto<ReadBankInformationDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var bankInformations = _bankInformationDomainService.GetAll();
            int total = bankInformations.Count();
            bankInformations = bankInformations.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadBankInformationDto>>(bankInformations.ToList());
            return new PagedResultDto<ReadBankInformationDto>(total, list);
        }

        public async Task<ReadBankInformationDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadBankInformationDto>(await _bankInformationDomainService.GetbyId(id));
        }

        public async Task<InsertBankInformationDto> Insert(InsertBankInformationDto bankInformation)
        {
            return ObjectMapper.Map<InsertBankInformationDto>(await _bankInformationDomainService.Insert(ObjectMapper.Map<BankInformation>(bankInformation)));
        }

        public async Task<UpdateBankInformationDto> Update(UpdateBankInformationDto bankInformation)
        {
            return ObjectMapper.Map<UpdateBankInformationDto>(await _bankInformationDomainService.Update(ObjectMapper.Map<BankInformation>(bankInformation)));
        }
    }
}
