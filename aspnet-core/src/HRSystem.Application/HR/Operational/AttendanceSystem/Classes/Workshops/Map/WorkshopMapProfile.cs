using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Map
{
    public class WorkshopMapProfile :Profile
    {
        public WorkshopMapProfile()
        {
            CreateMap<Workshop, ReadWorkshopDto>();
            CreateMap<ReadWorkshopDto, Workshop>();
            CreateMap<Workshop, InsertWorkshopDto>();
            CreateMap<InsertWorkshopDto, Workshop>();
            CreateMap<Workshop, UpdateWorkshopDto>();
            CreateMap<UpdateWorkshopDto, Workshop>();
        }
    }
}
