using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Services
{
    public interface IBankInformationAppService : IApplicationService
    {
        public Task<List<ReadBankInformationDto>> GetAll();
        public Task<ReadBankInformationDto> GetbyId(Guid id);
        public Task<InsertBankInformationDto> Insert(InsertBankInformationDto bankInformation);
        public Task<UpdateBankInformationDto> Update(UpdateBankInformationDto bankInformation);
        public Task Delete(Guid id);
    }
}
