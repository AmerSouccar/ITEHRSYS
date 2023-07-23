using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Services
{
    public interface ITransferAppService :IApplicationService
    {
        public Task<List<ReadTransferDto>> GetAll();
        public Task<ReadTransferDto> GetbyId(Guid id);
        public Task<InsertTransferDto> Insert(InsertTransferDto transfer);
        public Task<UpdateTransferDto> Update(UpdateTransferDto transfer);
        public Task Delete(Guid id);
    }
}
