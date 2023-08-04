using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Services
{
    public class PositionDomainService : IPositionDomainService
    {
        private readonly IRepository<Position,Guid> _positionRepository;

        public PositionDomainService(IRepository<Position, Guid> positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task Delete(Guid id)
        {
            await _positionRepository.DeleteAsync(id);
        }

        public IQueryable<Position> GetAll()
        {
            return _positionRepository.GetAllIncluding(x => x.JobDescription, x => x.PositionWorkType, x => x.ManagerJobTitle, x => x.Manager);
        }

        public async Task<Position> GetbyId(Guid id)
        {
            var position = await _positionRepository.GetAsync(id);
            if(position != null)
            {
                await _positionRepository.EnsurePropertyLoadedAsync(position, x => x.JobDescription);
                await _positionRepository.EnsurePropertyLoadedAsync(position, x => x.PositionWorkType);
                await _positionRepository.EnsurePropertyLoadedAsync(position, x => x.ManagerJobTitle);
                await _positionRepository.EnsurePropertyLoadedAsync(position, x => x.Manager);
            }
            return position;
        }

        public async Task<Position> Insert(Position position)
        {
            return await _positionRepository.InsertAsync(position);
        }

        public async Task<Position> Update(Position position)
        {
            return await _positionRepository.UpdateAsync(position);
        }
    }
}
