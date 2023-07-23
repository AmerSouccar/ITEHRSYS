using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Map
{
    public class ChangeableHolidayMapProfile :Profile
    {
        public ChangeableHolidayMapProfile()
        {
            CreateMap<ChangeableHoliday, ReadChangeableHolidayDto>();
            CreateMap<ReadChangeableHolidayDto, ChangeableHoliday>();
            CreateMap<ChangeableHoliday, InsertChangeableHolidayDto>();
            CreateMap<InsertChangeableHolidayDto, ChangeableHoliday>();
            CreateMap<ChangeableHoliday, UpdateChangeableHolidayDto>();
            CreateMap<UpdateChangeableHolidayDto, ChangeableHoliday>();
        }
    }
}
