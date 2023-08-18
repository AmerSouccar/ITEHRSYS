using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Services
{
    public interface IPositionDomainService : IDomainService
    {
        public IQueryable<Position>GetAll();
        public IQueryable<Position>GetAllEmptyPositions();
        public Task<Position> GetbyId(Guid id);
        public Task<Position> Insert(Position position);
        public Task<Position> Update(Position position);
        public Task Delete(Guid id);
    }
}
