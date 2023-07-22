using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Map
{
    public class NormalShiftMapProfile :Profile
    {
        public NormalShiftMapProfile()
        {
            CreateMap<NormalShift, ReadNormalShiftDto>();
            CreateMap<ReadNormalShiftDto, NormalShift>();
            CreateMap<NormalShift, InsertNormalShiftDto>();
            CreateMap<InsertNormalShiftDto, NormalShift>();
            CreateMap<NormalShift, UpdateNormalShiftDto>();
            CreateMap<UpdateNormalShiftDto, NormalShift>();
        }
    }
}
