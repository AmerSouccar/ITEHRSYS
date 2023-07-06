using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Services
{
    public interface IEmployeeAppService : IApplicationService
    {
        public Task<List<ReadEmployeeDto>> GetAll();
        public Task<ReadEmployeeDto> GetbyId(Guid id);
        public Task<InsertEmployeeDto> Insert(InsertEmployeeDto employee);
        public Task<UpdateEmployeeDto> Update(UpdateEmployeeDto employee);
        public Task Delete(Guid id);
    }
}
