using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto;
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

        public async Task<List<ReadTransferDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadTransferDto>>(await _transferdomainService.GetAll());
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
