using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Enums;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades
{
    public class Grade : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public OrganizationLevel OrganizationLevel { get; set; }
        public EducationGrade EducationGrade { get; set; }
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
        public Currency? Currency { get; set; }
        public GradeCategory GradeCategory { get; set; }
        //public LeaveTemplate LeaveTemplateMaster { get; set; }
        //public AttendanceForm AttendanceForm { get; set; }
        //public LatnessForm LatnessForm { get; set; }
        //public OvertimeForm OvertimeForm { get; set; }
        //public AbsenceForm AbsenceForm { get; set; }
        public List<JobTitle> JobTitles { get; set; }
        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; 
    }
}
