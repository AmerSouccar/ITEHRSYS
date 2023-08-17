using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Services
{
    public interface IAssignmentAppService : IApplicationService
    {
        public PagedResultDto<ReadAssignmentDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadAssignmentDto> GetbyId(Guid id);
        public Task<InsertAssignmentDto> Insert(InsertAssignmentDto assignment);
        public Task<UpdateAssignmentDto> Update(UpdateAssignmentDto assignment);
        public Task Delete(Guid id);
    }
}
