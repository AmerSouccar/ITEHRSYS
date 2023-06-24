using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Services
{
    public class DependentDomainService : IDependentDomainService
    {
        private readonly IRepository<Dependent, Guid> _dependenRepository;

        public DependentDomainService(IRepository<Dependent, Guid> dependenRepository)
        {
            _dependenRepository = dependenRepository;
        }

        public async Task Delete(Guid id)
        {
            await _dependenRepository.DeleteAsync(id);
        }

        public async Task<List<Dependent>> GetAll()
        {
            return _dependenRepository.GetAllIncluding(x => x.KinshipType,x => x.PlaceofBirth,x => x.Nationality,x => x.Attachments).ToList();
        }

        public async Task<Dependent> GetbyId(Guid id)
        {
           return _dependenRepository.GetAllIncluding(x => x.KinshipType, x => x.PlaceofBirth, x => x.Nationality, x => x.Attachments).FirstOrDefault(x  => x.Id == id);
        }

        public async Task<Dependent> Insert(Dependent dependent)
        {
            return await _dependenRepository.InsertAsync(dependent);
        }

        public async Task<Dependent> Update(Dependent dependent)
        {
            return await _dependenRepository.UpdateAsync(dependent);
        }
    }
}
