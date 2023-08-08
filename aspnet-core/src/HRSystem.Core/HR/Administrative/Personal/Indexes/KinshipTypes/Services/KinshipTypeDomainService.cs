using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Services
{
    internal class KinshipTypeDomainService : IKinshipTypeDomainService
    {
        private readonly IRepository<KinshipType, Guid> _kinshipTypes;

        public KinshipTypeDomainService(IRepository<KinshipType, Guid> kinshipTypes)
        {
            _kinshipTypes = kinshipTypes;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _kinshipTypes.DeleteAsync(id);
        }

        public async Task<KinshipType> GetbyId(Guid id)
        {
            return await _kinshipTypes.GetAsync(id);
        }

        public IQueryable<KinshipType> GetAll()
        {
            return _kinshipTypes.GetAll();
        }

        public async Task<KinshipType> InsertAsync(KinshipType kinshipType)
        {
            return await _kinshipTypes.InsertAsync(kinshipType);
        }

        public async Task<KinshipType> UpdateAsync(KinshipType kinshipType)
        {
            return await _kinshipTypes.UpdateAsync(kinshipType);
        }
    }
}
