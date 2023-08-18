using Abp.Domain.Repositories;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Services
{
    public class AssignmentDomainService : IAssignmentDomainService
    {
        private readonly IRepository<Assignment,Guid> _assignmentRepository;
        private readonly IRepository<EmployeeCard,Guid> _employeeCard;
        private readonly IRepository<Position,Guid> _positionRepository;

        public AssignmentDomainService(IRepository<Assignment, Guid> assignmentRepository, IRepository<EmployeeCard, Guid> employeeCard, IRepository<Position, Guid> positionRepository)
        {
            _assignmentRepository = assignmentRepository;
            _employeeCard = employeeCard;
            _positionRepository = positionRepository;
        }

        public async Task Delete(Guid id)
        {
            await _assignmentRepository.DeleteAsync(id);
        }

        public IQueryable<Assignment> GetAll()
        {
            return _assignmentRepository.GetAllIncluding(x => x.JobTitle, x => x.Position.JobDescription, x => x.EmployeeCard.Employee);
        }

        public async Task<Assignment> GetbyId(Guid id)
        {
            Assignment assignment = await _assignmentRepository.GetAsync(id);
            if (assignment != null)
            {
                await _assignmentRepository.EnsurePropertyLoadedAsync(assignment, x => x.JobTitle);
                await _assignmentRepository.EnsurePropertyLoadedAsync(assignment, x => x.Position);
                await _assignmentRepository.EnsurePropertyLoadedAsync(assignment, x => x.EmployeeCard);
            }
            return assignment;
        }

        public async Task<Assignment> Insert(Assignment assignment)
        {
            var employeeCard = await _employeeCard.GetAsync(assignment.EmployeeCardId);
            await _employeeCard.EnsurePropertyLoadedAsync(employeeCard, x => x.Employee);
            var position = await _positionRepository.GetAsync(assignment.PositionID);
            position.Employee = employeeCard.Employee;
            await _positionRepository.UpdateAsync(position);
            employeeCard.Position = position;
            await _employeeCard.UpdateAsync(employeeCard);
            return await _assignmentRepository.InsertAsync(assignment);
        }

        public async Task<Assignment> Update(Assignment assignment)
        {
            return await _assignmentRepository.UpdateAsync(assignment);

        }
    }
}
