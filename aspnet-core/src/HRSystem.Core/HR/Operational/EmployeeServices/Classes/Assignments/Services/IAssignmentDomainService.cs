using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Services
{
    public interface IAssignmentDomainService :IDomainService
    {
        public Task<List<Assignment>> GetAll();
        public Task<Assignment> GetbyId(Guid id);
        public Task<Assignment> Insert(Assignment assignment);
        public Task<Assignment> Update(Assignment assignment);
        public Task Delete(Guid id);
    }
}
