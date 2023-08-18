using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Services
{
    public class CompanyHolidayAppService : HRSystemAppServiceBase, ICompanyHolidayAppService
    {
        private readonly ICompanyHolidayDomainService _companyHolidaydomainService;

        public CompanyHolidayAppService(ICompanyHolidayDomainService companyHolidaydomainService)
        {
            _companyHolidaydomainService = companyHolidaydomainService;
        }

        public async Task Delete(Guid id)
        {
            await _companyHolidaydomainService.Delete(id);
        }

        public PagedResultDto<ReadCompanyHolidayDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var holidays = _companyHolidaydomainService.GetAll();
            int total = holidays.Count();
            holidays = holidays.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadCompanyHolidayDto>>(holidays.ToList());
            return new PagedResultDto<ReadCompanyHolidayDto>(total, list);
        }

        public async Task<ReadCompanyHolidayDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadCompanyHolidayDto>(await _companyHolidaydomainService.GetbyId(id));
        }

        public async Task<UpdateCompanyHolidayDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateCompanyHolidayDto>(await _companyHolidaydomainService.GetbyId(id));
        }

        public async Task<InsertCompanyHolidayDto> Insert(InsertCompanyHolidayDto companyHoliday)
        {
            return ObjectMapper.Map<InsertCompanyHolidayDto>(await _companyHolidaydomainService.Insert(ObjectMapper.Map<CompanyHoliday>(companyHoliday)));
        }

        public async Task<UpdateCompanyHolidayDto> Update(UpdateCompanyHolidayDto companyHoliday)
        {
            return ObjectMapper.Map<UpdateCompanyHolidayDto>(await _companyHolidaydomainService.Update(ObjectMapper.Map<CompanyHoliday>(companyHoliday)));

        }
    }
}
