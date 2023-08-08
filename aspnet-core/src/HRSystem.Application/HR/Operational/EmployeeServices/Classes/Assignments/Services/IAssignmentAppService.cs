using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Services
{
    public interface IAssignmentAppService : IApplicationService
    {
        public Task<List<ReadAssignmentDto>> GetAll();
        public Task<ReadAssignmentDto> GetbyId(Guid id);
        public Task<InsertAssignmentDto> Insert(InsertAssignmentDto assignment);
        public Task<UpdateAssignmentDto> Update(UpdateAssignmentDto assignment);
        public Task Delete(Guid id);
    }
}
