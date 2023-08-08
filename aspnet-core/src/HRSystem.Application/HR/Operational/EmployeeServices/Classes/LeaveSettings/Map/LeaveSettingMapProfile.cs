using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Map
{
    public class LeaveSettingMapProfile : Profile
    {
        public LeaveSettingMapProfile()
        {
            CreateMap<LeaveSetting, ReadLeaveSettingDto>();
            CreateMap<ReadLeaveSettingDto, LeaveSetting>();
            CreateMap<LeaveSetting, InsertLeaveSettingDto>();
            CreateMap<InsertLeaveSettingDto, LeaveSetting>();
            CreateMap<LeaveSetting, UpdateLeaveSettingDto>();
            CreateMap<UpdateLeaveSettingDto, LeaveSetting>();
        }
    }
}
