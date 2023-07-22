using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Map
{
    public class HourlyMissionMapProfile :Profile
    {
        public HourlyMissionMapProfile()
        {
            CreateMap<HourlyMission, ReadHourlyMissionDto>();
            CreateMap<ReadHourlyMissionDto, HourlyMission>();
            CreateMap<HourlyMission, InsertHourlyMissionDto>();
            CreateMap<InsertHourlyMissionDto, HourlyMission>();
            CreateMap<HourlyMission, UpdateHourlyMissionDto>();
            CreateMap<UpdateHourlyMissionDto, HourlyMission>();
        }
    }
}
