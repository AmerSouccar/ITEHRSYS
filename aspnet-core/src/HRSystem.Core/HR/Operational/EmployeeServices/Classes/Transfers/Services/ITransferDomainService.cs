using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Services
{
    public interface ITransferDomainService :IDomainService
    {
        public IQueryable<Transfer> GetAll();
        public Task<Transfer> GetbyId(Guid id);
        public Task<Transfer> Insert(Transfer transfer);
        public Task<Transfer> Update(Transfer transfer);
        public Task Delete(Guid id);
    }
}
