using Abp.Domain.Repositories;
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

        public AssignmentDomainService(IRepository<Assignment, Guid> assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task Delete(Guid id)
        {
            await _assignmentRepository.DeleteAsync(id);
        }

        public async Task<List<Assignment>> GetAll()
        {
            return _assignmentRepository.GetAllIncluding(x => x.JobTitle, x => x.Position, x => x.EmployeeCard).ToList();
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
            return await _assignmentRepository.InsertAsync(assignment);

        }

        public async Task<Assignment> Update(Assignment assignment)
        {
            return await _assignmentRepository.UpdateAsync(assignment);

        }
    }
}
