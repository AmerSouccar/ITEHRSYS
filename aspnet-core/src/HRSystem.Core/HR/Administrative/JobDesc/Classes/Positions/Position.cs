using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Enums;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions
{
    public class Position : FullAuditedAggregateRoot<Guid>
    {
        #region JobDescription
        [ForeignKey("JobDescription")]
        public Guid JobDescriptionId { get; set; }
        public JobDescription JobDescription { get; set; }
        #endregion
        #region PositionWorkType
        [ForeignKey("PositionWorkType")]
        public Guid PositionWorkTypeId { get; set; }
        public PositionWorkType PositionWorkType { get; set; }
        #endregion
        public double WorkingHours { get; set; }
        public HoursPer Per { get; set; }
        public bool HasManager { get; set; }
        #region ManagerJobTitle
        [ForeignKey("ManagerJobTitle")]
        public Guid? ManagerJobTitleId { get; set; }
        public JobTitle? ManagerJobTitle { get; set; }
        #endregion
        #region Manager
        [ForeignKey("Manager")]
        public Guid? ManagerId { get; set; }
        public JobDescription? Manager { get; set; }
        #endregion

        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }
    }
}
