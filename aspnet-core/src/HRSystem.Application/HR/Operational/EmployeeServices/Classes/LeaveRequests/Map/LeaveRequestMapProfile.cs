using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Map
{
    public class LeaveRequestMapProfile : Profile
    {
        public LeaveRequestMapProfile()
        {
            CreateMap<LeaveRequest, ReadLeaveRequestDto>();
            CreateMap<ReadLeaveRequestDto, LeaveRequest>();
            CreateMap<LeaveRequest, InsertLeaveRequestDto>();
            CreateMap<InsertLeaveRequestDto, LeaveRequest>();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>();
            CreateMap<UpdateLeaveRequestDto, LeaveRequest>();
        }
    }
}
