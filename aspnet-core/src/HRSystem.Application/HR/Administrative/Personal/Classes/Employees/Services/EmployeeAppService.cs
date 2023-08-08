using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Services
{
    public class EmployeeAppService : HRSystemAppServiceBase, IEmployeeAppService
    {
        private readonly IEmployeeDomainService _employeeDomainService;

        public EmployeeAppService(IEmployeeDomainService employeeDomainService)
        {
            _employeeDomainService = employeeDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _employeeDomainService.Delete(id);
        }

        public PagedResultDto<ReadEmployeeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var employees = _employeeDomainService.GetAll();
            int total = employees.Count();
            employees = employees.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadEmployeeDto>>(employees.ToList());
            return new PagedResultDto<ReadEmployeeDto>(total, list);
        }

        public async Task<ReadEmployeeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadEmployeeDto>(await _employeeDomainService.GetbyId(id));
        }

        public async Task<InsertEmployeeDto> Insert(InsertEmployeeDto employee)
        {
            return ObjectMapper.Map<InsertEmployeeDto>(await _employeeDomainService.Insert(ObjectMapper.Map<Employee>(employee)));
        }

        public async Task<UpdateEmployeeDto> Update(UpdateEmployeeDto employee)
        {
            return ObjectMapper.Map<UpdateEmployeeDto>(await _employeeDomainService.Update(ObjectMapper.Map<Employee>(employee)));
        }
    }
}
