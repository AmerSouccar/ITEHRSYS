using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Services
{
    public class PositionWorkTypeDomainService : IPositionWorkTypeDomainService
    {
        private readonly IRepository<PositionWorkType,Guid> _positionWorkType;

        public PositionWorkTypeDomainService(IRepository<PositionWorkType, Guid> positionWorkType)
        {
            _positionWorkType = positionWorkType;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _positionWorkType.DeleteAsync(id);
        }

        public  IQueryable<PositionWorkType> GetAll()
        {
            return  _positionWorkType.GetAll();
        }

        public async Task<PositionWorkType> GetbyId(Guid id)
        {
            return await _positionWorkType.GetAsync(id);
        }

        public async Task<PositionWorkType> InsertAsync(PositionWorkType positionWorkType)
        {
            return await _positionWorkType.InsertAsync(positionWorkType);
        }

        public async Task<PositionWorkType> UpdateAsync(PositionWorkType positionWorkType)
        {
            return await _positionWorkType.UpdateAsync(positionWorkType);
        }
    }
}
