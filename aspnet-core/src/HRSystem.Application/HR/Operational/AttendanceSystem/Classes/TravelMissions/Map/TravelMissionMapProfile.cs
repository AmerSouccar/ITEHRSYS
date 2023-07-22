using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Map
{
    public class TravelMissionMapProfile :Profile
    {
        public TravelMissionMapProfile()
        {
            CreateMap<TravelMission, ReadTravelMissionDto>();
            CreateMap<ReadTravelMissionDto, TravelMission>();
            CreateMap<TravelMission, InsertTravelMissionDto>();
            CreateMap<InsertTravelMissionDto, TravelMission>();
            CreateMap<TravelMission, UpdateTravelMissionDto>();
            CreateMap<UpdateTravelMissionDto, TravelMission>();
        }
    }
}
