using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.Grades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Dto
{
    public class UpdateGradeDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public Guid OrganizationLevelId { get; set; }
        public Guid EducationGradeId { get; set; }
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
        public Currency? Currency { get; set; }
        public GradeCategory GradeCategory { get; set; }
        //public LeaveTemplate LeaveTemplateMaster { get; set; }
        //public AttendanceForm AttendanceForm { get; set; }
        //public LatnessForm LatnessForm { get; set; }
        //public OvertimeForm OvertimeForm { get; set; }
        //public AbsenceForm AbsenceForm { get; set; }
        public List<ReadJobTitleDto> JobTitles { get; set; }
        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; 
    }
}
