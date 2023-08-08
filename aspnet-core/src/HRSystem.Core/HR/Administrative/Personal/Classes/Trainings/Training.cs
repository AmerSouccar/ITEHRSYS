using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings
{
    public class Training : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        #region Course
        public string Specialize { get; set; }
        public string CourseName { get; set; }
        public DateTime? CourseStartDate { get; set; }
        public DateTime? CourseEndDate { get; set; }
        public int? CourseDurationPerHour { get; set; }
        #endregion
        #region Training Center
        public string TrainingCenter { get; set; }
        public string TrainingCenterLocation { get; set; }
        public string Instructor { get; set; }
        public string InstructorPhone { get; set; }
        public DateTime? CertificateIssuanceDate { get; set; }
        public bool isActive { get; set; }
        public string Notes { get; set; }

        #endregion
        public List<Attachment> Attachments { get; set; }
    }
}
