using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.Grades.Enums;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Dto
{
    public class ReadGradeDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        #region  OrganizationLevel
        public Guid OrganizationLevelId { get; set; }
        public ReadOrganizationLevelDto OrganizationLevel { get; set; }
        #endregion
        #region EducationGrade
        public Guid EducationGradeId { get; set; }
        public ReadEducationGradeDto EducationGrade { get; set; }
        #endregion
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
        public int? Currency { get; set; }
        public int GradeCategory { get; set; }
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
