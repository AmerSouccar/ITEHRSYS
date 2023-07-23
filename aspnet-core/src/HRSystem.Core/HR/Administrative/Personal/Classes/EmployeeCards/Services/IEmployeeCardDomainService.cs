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
        public Task<List<ReadEmployeeCardDto>> GetAll();
        public Task<ReadEmployeeCardDto> GetbyId(Guid id);
        public Task<ReadEmployeeCardDto> Insert(ReadEmployeeCardDto employeeCard);
        public Task<ReadEmployeeCardDto> Update(ReadEmployeeCardDto employeeCard);
        public Task Delete(Guid id);
    }
}
