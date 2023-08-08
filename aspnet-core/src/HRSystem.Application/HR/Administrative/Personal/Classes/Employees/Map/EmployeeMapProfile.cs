using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Map
{
    public class EmployeeMapProfile : Profile
    {
        public EmployeeMapProfile()
        {
            CreateMap<ReadEmployeeDto, Employee>();
            CreateMap<Employee, ReadEmployeeDto>();
            CreateMap<InsertEmployeeDto, Employee>();
            CreateMap<Employee, InsertEmployeeDto>();
            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee, UpdateEmployeeDto>();
        }
    }
}
