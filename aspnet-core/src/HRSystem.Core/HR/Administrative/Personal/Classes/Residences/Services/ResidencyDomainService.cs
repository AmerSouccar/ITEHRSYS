using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Services
{
    public class ResidencyDomainService : IResidencyDomainService
    {
        private readonly IRepository<Residency, Guid> _residencyRepository;

        public ResidencyDomainService(IRepository<Residency, Guid> residencyRepository)
        {
            _residencyRepository = residencyRepository;
        }

        public async Task Delete(Guid id)
        {
            await _residencyRepository.DeleteAsync(id);
        }

        public async Task<List<Residency>> GetAll()
        {
           return _residencyRepository.GetAllIncluding(x => x.Nationality,x => x.Attachments).ToList();
        }

        public async Task<Residency> GetbyId(Guid id)
        {
           return _residencyRepository.GetAllIncluding(x => x.Nationality, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Residency> Insert(Residency Residency)
        {
            return await _residencyRepository.InsertAsync(Residency);
        }

        public async Task<Residency> Update(Residency Residency)
        {
            return await _residencyRepository.UpdateAsync(Residency);
        }
    }
}
