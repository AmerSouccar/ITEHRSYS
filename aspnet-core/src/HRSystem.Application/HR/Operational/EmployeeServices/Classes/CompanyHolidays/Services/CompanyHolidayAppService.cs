using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto;
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

        public async Task<List<ReadCompanyHolidayDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadCompanyHolidayDto>>(await _companyHolidaydomainService.GetAll());
        }

        public async Task<ReadCompanyHolidayDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadCompanyHolidayDto>(await _companyHolidaydomainService.GetbyId(id));
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
