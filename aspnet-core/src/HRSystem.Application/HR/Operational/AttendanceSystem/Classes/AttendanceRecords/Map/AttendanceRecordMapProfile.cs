using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Map
{
    public class AttendanceRecordMapProfile : Profile
    {
        public AttendanceRecordMapProfile()
        {
            CreateMap<AttendanceRecord, ReadAttendanceRecordDto>();
            CreateMap<ReadAttendanceRecordDto, AttendanceRecord>();
            CreateMap<AttendanceRecord, InsertAttendanceRecordDto>();
            CreateMap<InsertAttendanceRecordDto, AttendanceRecord>();
            CreateMap<AttendanceRecord, UpdateAttendanceRecordDto>();
            CreateMap<UpdateAttendanceRecordDto, AttendanceRecord>();
        }
    }
}
