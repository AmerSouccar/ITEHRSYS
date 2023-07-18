using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Services
{
    public interface IResignationdomainService :IDomainService
    {
        public Task<List<Resignation>> GetAll();
        public Task<Resignation> GetbyId(Guid id);
        public Task<Resignation> Insert(Resignation resignation);
        public Task<Resignation> Update(Resignation resignation);
        public Task Delete(Guid id);
    }
}
