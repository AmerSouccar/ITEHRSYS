using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Dto
{
    public class InsertTrainingDto :EntityDto<Guid>
    {
        public class Training : FullAuditedAggregateRoot<Guid>
        {
            public Guid EmployeeId { get; set; }

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
        }
    }
}
