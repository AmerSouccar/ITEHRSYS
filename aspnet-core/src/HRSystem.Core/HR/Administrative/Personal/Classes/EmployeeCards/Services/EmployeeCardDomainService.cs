using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Services
{
    public class EmployeeCardDomainService : IEmployeeCardDomainService
    {
        private readonly IRepository<EmployeeCard, Guid> _employeeCardRepository;

        public EmployeeCardDomainService(IRepository<EmployeeCard, Guid> employeeCardRepository)
        {
            _employeeCardRepository = employeeCardRepository;
        }

        public async Task Delete(Guid id)
        {
            await _employeeCardRepository.DeleteAsync(id);
        }

        public IQueryable<EmployeeCard> GetAll()
        {
            //return _employeeCardRepository.GetAllIncluding(x => x.JobDescription, x => x.Employee, x => x.Position, x => x.JobTitle, x => x.Grade, x => x.Custodies, x => x.Assignments, x => x.Transfers, x => x.Resignations, x => x.Promotions, x => x.LeaveRequests);
            return _employeeCardRepository.GetAllIncluding(x => x.JobDescription, x => x.Employee, x => x.Position, x => x.JobTitle, x => x.Grade);
        }

        public IQueryable<EmployeeCard> GetAllForDropDown()
        {
            return _employeeCardRepository.GetAllIncluding(x => x.Employee);
        }

        public async Task<EmployeeCard> GetbyId(Guid id)
        {
            return _employeeCardRepository.GetAllIncluding(x => x.JobDescription, x => x.Employee, x => x.Position, x => x.JobTitle, x => x.Grade, x => x.Custodies, x => x.Assignments, x => x.Transfers, x => x.Resignations, x => x.Promotions, x => x.LeaveRequests).FirstOrDefault(x => x.Id == id);
        }

        public async Task<EmployeeCard> Insert(EmployeeCard employeeCard)
        {
           return await _employeeCardRepository.InsertAsync(employeeCard);
        }

        public async Task<EmployeeCard> Update(EmployeeCard employeeCard)
        {
            return await _employeeCardRepository.UpdateAsync(employeeCard);
        }
    }
}
