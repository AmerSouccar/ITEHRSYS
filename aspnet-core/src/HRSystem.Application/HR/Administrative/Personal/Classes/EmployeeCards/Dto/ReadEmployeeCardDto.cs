using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Dto
{
    public class ReadEmployeeCardDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }
        public string FatherName
        {
            get
            {
                return this.Employee.FatherName;
            }
        }
        public Guid? JobDescriptionId { get; set; }
        public ReadJobDescriptionDto? JobDescription { get; set; }
        public Guid? PositionId { get; set; }
        public ReadPositionDto? Position { get; set; }
        public Guid? JobTitleId { get; set; }
        public ReadJobTitleDto? JobTitle { get; set; }
        public Guid? GradeId { get; set; }
        public ReadGradeDto? Grade { get; set; }
        public Guid? AttendanceFormId { get; set; }
        public ReadAttendanceFormDto? AttendanceForm { get; set; }
        public string StartWorkingDate { get; set; }
        public string EndWorkingDate { get; set; }
        public string ProbationPeriodDate { get; set; }
        public int ContractType { get; set; }
    }
}
