using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Services
{
    public interface IBankInformationDomainService : IDomainService
    {
        public Task<List<BankInformation>> GetAll();
        public Task<BankInformation> GetbyId(Guid id);
        public Task<BankInformation> Insert(BankInformation bankInformation);
        public Task<BankInformation> Update(BankInformation bankInformation);
        public Task Delete(Guid id);
    }
}
