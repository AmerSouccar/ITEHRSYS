using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Services
{
    public class SpouseDomainService : ISpouseDomainService
    {
        private readonly IRepository<Spouse, Guid> _spouseRepository;

        public SpouseDomainService(IRepository<Spouse, Guid> spouseRepository)
        {
            _spouseRepository = spouseRepository;
        }

        public async Task Delete(Guid id)
        {
           await _spouseRepository.DeleteAsync(id);
        }

        public async Task<List<Spouse>> GetAll()
        {
            return _spouseRepository.GetAllIncluding(x => x.PlaceofBirth,x => x.Nationality,x => x.Attachments).ToList();
        }

        public async Task<Spouse> GetbyId(Guid id)
        {
            return _spouseRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.Nationality, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Spouse> Insert(Spouse spouse)
        {
           return await _spouseRepository.InsertAsync(spouse);
        }

        public async Task<Spouse> Update(Spouse spouse)
        {
            return await _spouseRepository.UpdateAsync(spouse);
        }
    }
}
