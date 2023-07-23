using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Services
{
    public class AssignmentAppService : HRSystemAppServiceBase, IAssignmentAppService
    {
        private readonly IAssignmentDomainService _assignmentDomainService;

        public AssignmentAppService(IAssignmentDomainService assignmentDomainService)
        {
            _assignmentDomainService = assignmentDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _assignmentDomainService.Delete(id);
        }

        public async Task<List<ReadAssignmentDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadAssignmentDto>>(await _assignmentDomainService.GetAll()); 
        }

        public async Task<ReadAssignmentDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadAssignmentDto>(await _assignmentDomainService.GetbyId(id));
        }

        public async Task<InsertAssignmentDto> Insert(InsertAssignmentDto assignment)
        {
            return ObjectMapper.Map<InsertAssignmentDto>(await _assignmentDomainService.Insert(ObjectMapper.Map<Assignment>(assignment)));
        }

        public async Task<UpdateAssignmentDto> Update(UpdateAssignmentDto assignment)
        {
            return ObjectMapper.Map<UpdateAssignmentDto>(await _assignmentDomainService.Update(ObjectMapper.Map<Assignment>(assignment)));

        }
    }
}
