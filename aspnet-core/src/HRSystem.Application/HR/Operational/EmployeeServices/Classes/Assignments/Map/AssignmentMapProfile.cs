using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Map
{
    public class AssignmentMapProfile : Profile
    {
        public AssignmentMapProfile()
        {
            CreateMap<Assignment, ReadAssignmentDto>();
            CreateMap<ReadAssignmentDto, Assignment>();
            CreateMap<Assignment, InsertAssignmentDto>();
            CreateMap<InsertAssignmentDto, Assignment>();
            CreateMap<Assignment, UpdateAssignmentDto>();
            CreateMap<UpdateAssignmentDto, Assignment>();
        }
    }
}
