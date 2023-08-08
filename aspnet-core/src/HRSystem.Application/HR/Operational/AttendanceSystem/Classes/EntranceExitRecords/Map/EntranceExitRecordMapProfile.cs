using AutoMapper;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Map
{
    public class EntranceExitRecordMapProfile :Profile
    {
        public EntranceExitRecordMapProfile()
        {
            CreateMap<EntranceExitRecord, ReadEntranceExitRecordDto>();
            CreateMap<ReadEntranceExitRecordDto, EntranceExitRecord>();
            CreateMap<EntranceExitRecord, InsertEntranceExitRecordDto>();
            CreateMap<InsertEntranceExitRecordDto, EntranceExitRecord>();
            CreateMap<EntranceExitRecord, UpdateEntranceExitRecordDto>();
            CreateMap<UpdateEntranceExitRecordDto, EntranceExitRecord>();
        }
    }
}
