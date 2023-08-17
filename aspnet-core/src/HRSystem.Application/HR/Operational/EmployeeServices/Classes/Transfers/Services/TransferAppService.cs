using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Services
{
    public class TransferAppService : HRSystemAppServiceBase, ITransferAppService
    {
        private readonly ITransferDomainService _transferdomainService;

        public TransferAppService(ITransferDomainService transferdomainService)
        {
            _transferdomainService = transferdomainService;
        }

        public async Task Delete(Guid id)
        {
           await _transferdomainService.Delete(id);
        }

        public PagedResultDto<ReadTransferDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var transfers = _transferdomainService.GetAll();
            int total = transfers.Count();
            transfers = transfers.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadTransferDto>>(transfers.ToList());
            return new PagedResultDto<ReadTransferDto>(total, list);
        }

        public async Task<ReadTransferDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadTransferDto>(await _transferdomainService.GetbyId(id));
        }

        public async Task<InsertTransferDto> Insert(InsertTransferDto transfer)
        {
            return ObjectMapper.Map<InsertTransferDto>(await _transferdomainService.Insert(ObjectMapper.Map<Transfer>(transfer)));
        }

        public async Task<UpdateTransferDto> Update(UpdateTransferDto transfer)
        {
            return ObjectMapper.Map<UpdateTransferDto>(await _transferdomainService.Update(ObjectMapper.Map<Transfer>(transfer)));

        }
    }
}
