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

        public PagedResultDto<ReadAssignmentDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var assignments = _assignmentDomainService.GetAll();
            int total = assignments.Count();
            assignments = assignments.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadAssignmentDto>>(assignments.ToList());
            return new PagedResultDto<ReadAssignmentDto>(total, list);
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
