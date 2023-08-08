using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Services
{
    public interface IPromotionDomainService :IDomainService
    {
        public Task<List<Promotion>> GetAll();
        public Task<Promotion> GetbyId(Guid id);
        public Task<Promotion> Insert(Promotion promotion);
        public Task<Promotion> Update(Promotion promotion);
        public Task Delete(Guid id);
    }
}
