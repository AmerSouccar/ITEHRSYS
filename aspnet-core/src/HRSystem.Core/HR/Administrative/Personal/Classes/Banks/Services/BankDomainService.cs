using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Services
{
    public class BankDomainService : IBankDomainService
    {
        private readonly IRepository<Bank, Guid> _bankRepository;

        public BankDomainService(IRepository<Bank, Guid> bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public async Task Delete(Guid id)
        {
         await _bankRepository.DeleteAsync(id);
        }

        public async Task<List<Bank>> GetAll()
        {
            return _bankRepository.GetAllIncluding(x => x.Nationality).ToList();
        }

        public async Task<Bank> GetbyId(Guid id)
        {
            return _bankRepository.GetAllIncluding(x => x.Nationality).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Bank> Insert(Bank bank)
        {
          return await _bankRepository.InsertAsync(bank);
        }

        public async Task<Bank> Update(Bank bank)
        {
            return await _bankRepository.UpdateAsync(bank);
        }
    }
}
