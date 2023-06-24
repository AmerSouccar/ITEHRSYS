using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Services
{
    public interface IEmployeeDomanService : IDomainService
    {
        public Task<List<Employee>> GetAll();
        public Task<Employee> GetbyId(Guid id);
        public Task<Employee> Insert(Employee employee);
        public Task<Employee> Update(Employee employee);
        public Task Delete(Guid id);
    }
}
