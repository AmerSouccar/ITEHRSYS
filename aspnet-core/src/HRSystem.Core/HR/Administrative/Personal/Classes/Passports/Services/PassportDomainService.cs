using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Services
{
    public class PassportDomainService : IPassportDomainService
    {
        private readonly IRepository<Passport, Guid> _passportRepository;

        public PassportDomainService(IRepository<Passport, Guid> passportRepository)
        {
            _passportRepository = passportRepository;
        }

        public async Task Delete(Guid id)
        {
            await _passportRepository.DeleteAsync(id);
        }

        public async Task<List<Passport>> GetAll()
        {
            return _passportRepository.GetAllIncluding(x =>x.PlaceofIssuance, x => x.Attachments).ToList();
        }

        public async Task<Passport> GetbyId(Guid id)
        {
            return _passportRepository.GetAllIncluding(x => x.PlaceofIssuance, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Passport> Insert(Passport passport)
        {
            return await _passportRepository.InsertAsync(passport);
        }

        public async Task<Passport> Update(Passport passport)
        {
            return await _passportRepository.UpdateAsync(passport);
        }
    }
}
