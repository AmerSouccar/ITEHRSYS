using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Map
{
    public class AttendanceMonthlyCardMapProfile :Profile
    {
        public AttendanceMonthlyCardMapProfile()
        {
            CreateMap<AttendanceMonthlyCard, ReadAttendanceMonthlyCardDto>();
            CreateMap<ReadAttendanceMonthlyCardDto, AttendanceMonthlyCard>();
            CreateMap<AttendanceMonthlyCard, InsertAttendanceMonthlyCardDto>();
            CreateMap<InsertAttendanceMonthlyCardDto, AttendanceMonthlyCard>();
            CreateMap<AttendanceMonthlyCard, UpdateAttendanceMonthlyCardDto>();
            CreateMap<UpdateAttendanceMonthlyCardDto, AttendanceMonthlyCard>();
        }
    }
}
