using Abp.Domain.Repositories;
using HRSystem.Authorization.Users;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Services
{
    public class EmployeeDomainService : IEmployeeDomainService
    {
        private readonly IRepository<Employee, Guid> _employeeRepository;
        private readonly IRepository<EmployeeCard, Guid> _employeeCardRepository;
        private readonly IRepository<FinancialCard, Guid> _financialCardRepository;
        private readonly UserRegistrationManager _userRegistrationManager;

        public EmployeeDomainService(IRepository<Employee, Guid> employeeRepository, UserRegistrationManager userRegistrationManager, IRepository<EmployeeCard, Guid> employeeCardRepository, IRepository<FinancialCard, Guid> financialCardRepository)
        {
            _employeeRepository = employeeRepository;
            _userRegistrationManager = userRegistrationManager;
            _employeeCardRepository = employeeCardRepository;
            _financialCardRepository = financialCardRepository;
        }

        public async Task Delete(Guid id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        public IQueryable<Employee> GetAll()
        {
            return _employeeRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.CountryofBirth, x => x.Religion, x => x.Nationality, x => x.SecondaryNationality, x => x.Attachments, x => x.Spouse, x => x.Children, x => x.Dependents, x => x.Educations, x => x.Trainings, x => x.Experiences, x => x.Skills, x => x.Languages, x => x.Certificates, x => x.MilitaryService, x => x.Passports, x => x.DriverLicense, x => x.Convictions, x => x.Residences, x => x.Positions, x => x.User);
        }

        public async Task<Employee> GetbyId(Guid id)
        {
            return _employeeRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.CountryofBirth, x => x.Religion, x => x.Nationality, x => x.SecondaryNationality, x => x.Attachments, x => x.Spouse, x => x.Children, x => x.Dependents, x => x.Educations, x => x.Trainings, x => x.Experiences, x => x.Skills, x => x.Languages, x => x.Certificates, x => x.MilitaryService, x => x.Passports, x => x.DriverLicense, x => x.Convictions, x => x.Residences, x => x.Positions, x => x.User).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Employee> Insert(Employee employee)
        {
            var newUser = await _userRegistrationManager.RegisterAsync(employee.FirstName,employee.LastName,employee.Email, employee.Email, "123456",true);
            employee.UserId = newUser.Id;
            employee.User = newUser;
            var employeeId = await _employeeRepository.InsertAndGetIdAsync(employee);
            EmployeeCard employeeCard = new EmployeeCard()
            {
                EmployeeId = employeeId,
            };
            await _employeeCardRepository.InsertAsync(employeeCard);
            FinancialCard financialCard = new FinancialCard()
            {
                EmployeeId = employeeId,
                Salary = 0,
            };
            var t = await _financialCardRepository.InsertAsync(financialCard);
            return employee;
        }

        public async Task<Employee> Update(Employee employee)
        {
            return await _employeeRepository.UpdateAsync(employee);
        }
    }
}
