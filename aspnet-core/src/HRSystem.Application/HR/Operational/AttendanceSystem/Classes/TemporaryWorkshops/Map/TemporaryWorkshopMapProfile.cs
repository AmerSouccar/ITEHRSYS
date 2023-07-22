using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Map
{
    public class TemporaryWorkshopMapProfile : Profile
    {
        public TemporaryWorkshopMapProfile()
        {
            CreateMap<TemporaryWorkshop, ReadTemporaryWorkshopDto>();
            CreateMap<ReadTemporaryWorkshopDto, TemporaryWorkshop>();
            CreateMap<TemporaryWorkshop, InsertTemporaryWorkshopDto>();
            CreateMap<InsertTemporaryWorkshopDto, TemporaryWorkshop>();
            CreateMap<TemporaryWorkshop, UpdateTemporaryWorkshopDto>();
            CreateMap<UpdateTemporaryWorkshopDto, TemporaryWorkshop>();
        }
    }
}
