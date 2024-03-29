﻿using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Services
{
    public interface ICompanyHolidayAppService :IApplicationService
    {
        public Task<List<ReadCompanyHolidayDto>> GetAll();
        public Task<ReadCompanyHolidayDto> GetbyId(Guid id);
        public Task<InsertCompanyHolidayDto> Insert(InsertCompanyHolidayDto companyHoliday);
        public Task<UpdateCompanyHolidayDto> Update(UpdateCompanyHolidayDto companyHoliday);
        public Task Delete(Guid id);
    }
}
