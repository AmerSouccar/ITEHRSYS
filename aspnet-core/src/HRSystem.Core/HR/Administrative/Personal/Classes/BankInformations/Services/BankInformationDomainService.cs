using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Services
{
    public class BankInformationDomainService : IBankInformationDomainService
    {
        private readonly IRepository<BankInformation,Guid> _bankInformationRepository;

        public BankInformationDomainService(IRepository<BankInformation, Guid> bankInformationRepository)
        {
            _bankInformationRepository = bankInformationRepository;
        }

        public async Task Delete(Guid id)
        {
           await _bankInformationRepository.DeleteAsync(id);
        }

        public IQueryable<BankInformation> GetAll()
        {
            return _bankInformationRepository.GetAllIncluding(x => x.Bank);
        }

        public async Task<BankInformation> GetbyId(Guid id)
        {
           return _bankInformationRepository.GetAllIncluding(x => x.Bank).FirstOrDefault(x => x.Id == id);
        }

        public async Task<BankInformation> Insert(BankInformation bankInformation)
        {
            return await _bankInformationRepository.InsertAsync(bankInformation);
        }

        public async Task<BankInformation> Update(BankInformation bankInformation)
        {
           return await _bankInformationRepository.UpdateAsync(bankInformation);
        }
    }
}
