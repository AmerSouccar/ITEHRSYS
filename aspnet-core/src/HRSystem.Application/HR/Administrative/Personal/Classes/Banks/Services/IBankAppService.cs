using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Services
{
    public interface IBankAppService : IApplicationService
    {
        public PagedResultDto<ReadBankDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadBankDto> GetbyId(Guid id);
        public Task<InsertBankDto> Insert(InsertBankDto bank);
        public Task<UpdateBankDto> Update(UpdateBankDto bank);
        public Task Delete(Guid id);
    }
}
