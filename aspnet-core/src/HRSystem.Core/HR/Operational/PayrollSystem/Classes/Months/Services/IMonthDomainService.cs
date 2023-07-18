using Abp.Domain.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Services
{
    public interface IMonthDomainService :IDomainService
    {
        public Task<List<Month>> GetAll();
        public Task<Month> GetbyId(Guid id);
        public Task<Month> Insert(Month month);
        public Task<Month> Update(Month month);
        public Task Delete(Guid id);
    }
}
