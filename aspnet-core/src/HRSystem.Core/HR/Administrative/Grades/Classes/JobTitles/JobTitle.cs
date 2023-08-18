using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.Grades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles
{
    public class JobTitle : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public int EmployeeCount { get; set; }
        public string Description { get; set; }
        #region Grade
        [ForeignKey("Grade")]
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }
        #endregion

        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }

    }
}
