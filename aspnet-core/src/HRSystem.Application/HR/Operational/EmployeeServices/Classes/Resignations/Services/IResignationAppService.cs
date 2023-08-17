using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Services
{
    public interface IResignationAppService :IApplicationService
    {
        public PagedResultDto<ReadResignationDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadResignationDto> GetbyId(Guid id);
        public Task<InsertResignationDto> Insert(InsertResignationDto resignation);
        public Task<UpdateResignationDto> Update(UpdateResignationDto resignation);
        public Task Delete(Guid id);
    }
}
