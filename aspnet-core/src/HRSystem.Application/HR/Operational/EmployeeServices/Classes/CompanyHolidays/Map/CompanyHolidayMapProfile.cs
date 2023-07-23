using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Map
{
    public class CompanyHolidayMapProfile :Profile
    {
        public CompanyHolidayMapProfile()
        {
            CreateMap<CompanyHoliday, ReadCompanyHolidayDto>();
            CreateMap<ReadCompanyHolidayDto, CompanyHoliday>();
            CreateMap<CompanyHoliday, InsertCompanyHolidayDto>();
            CreateMap<InsertCompanyHolidayDto, CompanyHoliday>();
            CreateMap<CompanyHoliday, UpdateCompanyHolidayDto>();
            CreateMap<UpdateCompanyHolidayDto, CompanyHoliday>();
        }
    }
}
