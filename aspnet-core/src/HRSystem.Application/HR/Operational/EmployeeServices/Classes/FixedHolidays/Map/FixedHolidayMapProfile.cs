using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Map
{
    public class FixedHolidayMapProfile : Profile
    {
        public FixedHolidayMapProfile()
        {
            CreateMap<FixedHoliday, ReadFixedHolidayDto>();
            CreateMap<ReadFixedHolidayDto, FixedHoliday>();
            CreateMap<FixedHoliday, InsertFixedHolidayDto>();
            CreateMap<InsertFixedHolidayDto, FixedHoliday>();
            CreateMap<FixedHoliday, UpdateFixedHolidayDto>();
            CreateMap<UpdateFixedHolidayDto, FixedHoliday>();
        }
    }
}
