using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Services
{
    public interface IResignationAppService :IApplicationService
    {
        public Task<List<ReadResignationDto>> GetAll();
        public Task<ReadResignationDto> GetbyId(Guid id);
        public Task<InsertResignationDto> Insert(InsertResignationDto resignation);
        public Task<UpdateResignationDto> Update(UpdateResignationDto resignation);
        public Task Delete(Guid id);
    }
}
