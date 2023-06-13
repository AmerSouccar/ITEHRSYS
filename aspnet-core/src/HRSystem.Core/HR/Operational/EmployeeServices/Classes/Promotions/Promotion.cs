using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions
{
    public class Promotion : FullAuditedAggregateRoot<Guid>
    {
        #region JobTitle
        [ForeignKey("JobTitle")]
        public Guid JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        #endregion
        #region Position
        [ForeignKey("Position")]
        public Guid PositionId { get; set; }
        public Position Position { get; set; }
        #endregion
        #region EmployeeCard
        [ForeignKey("EmployeeCard")]
        public Guid EmployeeCardId { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        #endregion
        public DateTime PromotionDate { get; set; }
        public string Description { get; set; }
    }
}
