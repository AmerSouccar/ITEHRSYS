using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Services
{
    public class EmployeeCardAppService : HRSystemAppServiceBase, IEmployeeCardAppService
    {
        private readonly IEmployeeCardDomainService _employeeCardDomainService;

        public EmployeeCardAppService(IEmployeeCardDomainService employeeCardDomainService)
        {
            _employeeCardDomainService = employeeCardDomainService;
        }

        //public async Task Delete(Guid id)
        //{
        //    await _employeeDomainService.Delete(id);
        //}

        public PagedResultDto<ReadEmployeeCardDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var employeeCards = _employeeCardDomainService.GetAll();
            int total = employeeCards.Count();
            employeeCards = employeeCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadEmployeeCardDto>>(employeeCards.ToList());
            return new PagedResultDto<ReadEmployeeCardDto>(total, list);
        }

        public PagedResultDto<ReadEmployeeCardDto> GetAllForDropdown(PagedGeneralResultRequestDto input)
        {
            var employeeCards = _employeeCardDomainService.GetAllForDropDown();
            int total = employeeCards.Count();
            employeeCards = employeeCards.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadEmployeeCardDto>>(employeeCards.ToList());
            return new PagedResultDto<ReadEmployeeCardDto>(total, list);
        }

        public async Task<ReadEmployeeCardDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadEmployeeCardDto>(await _employeeCardDomainService.GetbyId(id));
        }

        public async Task<UpdateEmployeeCardDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateEmployeeCardDto>(await _employeeCardDomainService.GetbyId(id));
        }

        public async Task<UpdateEmployeeCardDto> Update(UpdateEmployeeCardDto employeeCard)
        {
            return ObjectMapper.Map<UpdateEmployeeCardDto>(await _employeeCardDomainService.Update(ObjectMapper.Map<EmployeeCard>(employeeCard)));
        }
    }
}
