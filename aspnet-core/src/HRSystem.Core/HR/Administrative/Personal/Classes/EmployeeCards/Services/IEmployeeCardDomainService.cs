using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Educations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Services
{
    public interface IEmployeeCardDomainService :IDomainService
    {
        public Task<List<EmployeeCard>> GetAll();
        public Task<EmployeeCard> GetbyId(Guid id);
        public Task<EmployeeCard> Insert(EmployeeCard employeeCard);
        public Task<EmployeeCard> Update(EmployeeCard employeeCard);
        public Task Delete(Guid id);
    }
}
