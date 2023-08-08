using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Services
{
    public interface IPositionWorkTypeDomainService : IDomainService
    {
        IQueryable<PositionWorkType> GetAll();
        Task<PositionWorkType> GetbyId(Guid id);
        Task<PositionWorkType> InsertAsync(PositionWorkType positionWorkType);
        Task<PositionWorkType> UpdateAsync(PositionWorkType positionWorkType);
        Task DeleteAsync(Guid id);
    }
}
