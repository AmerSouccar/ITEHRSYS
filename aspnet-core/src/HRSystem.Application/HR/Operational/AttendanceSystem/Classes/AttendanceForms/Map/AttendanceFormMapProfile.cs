using AutoMapper;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Map
{
    public class AttendanceFormMapProfile :Profile
    {
        public AttendanceFormMapProfile()
        {
            CreateMap<AttendanceForm, ReadAttendanceFormDto>();
            CreateMap<ReadAttendanceFormDto, AttendanceForm>();
            CreateMap<AttendanceForm, InsertAttendanceFormDto>();
            CreateMap<InsertAttendanceFormDto, AttendanceForm>();
            CreateMap<AttendanceForm, UpdateAttendanceFormDto>();
            CreateMap<UpdateAttendanceFormDto, AttendanceForm>();
        }
    }
}
