using Abp.Domain.Repositories;
using HRSystem.Authorization.Users;
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
        private readonly UserRegistrationManager _userRegistrationManager;

        public EmployeeDomainService(IRepository<Employee, Guid> employeeRepository, UserRegistrationManager userRegistrationManager)
        {
            _employeeRepository = employeeRepository;
            _userRegistrationManager = userRegistrationManager;
        }

        public async Task Delete(Guid id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        public async Task<List<Employee>> GetAll()
        {
            return _employeeRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.CountryofBirth, x => x.Religion, x => x.Nationality, x => x.SecondaryNationality, x => x.Attachments, x => x.Spouse, x => x.Children, x => x.Dependents, x => x.Educations, x => x.Trainings, x => x.Experiences, x => x.Skills, x => x.Languages, x => x.Certificates, x => x.MilitaryService, x => x.Passports, x => x.DriverLicense, x => x.Convictions, x => x.Residences, x => x.Positions, x => x.User).ToList();
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
            return await _employeeRepository.InsertAsync(employee);
        }

        public async Task<Employee> Update(Employee employee)
        {
            return await _employeeRepository.UpdateAsync(employee);
        }
    }
}
