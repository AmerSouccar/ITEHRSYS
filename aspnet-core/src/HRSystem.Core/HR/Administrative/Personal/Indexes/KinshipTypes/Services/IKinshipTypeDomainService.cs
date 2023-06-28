using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Services
{
    public interface IKinshipTypeDomainService : IDomainService
    {
        Task<List<KinshipType>> GetAllAsync();
        Task<KinshipType> GetbyId(Guid id);
        Task<KinshipType> InsertAsync(KinshipType kinshipType);
        Task<KinshipType> UpdateAsync(KinshipType kinshipType);
        Task DeleteAsync(Guid id);

    }
}
