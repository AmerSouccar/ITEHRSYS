using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.Registration;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions
{
    public class JobDescription : FullAuditedAggregateRoot<Guid>
    {
        #region JobTitle
        [ForeignKey("JobTitle")]
        public Guid JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        #endregion
        public string Name { get; set; }
        #region Node
        [ForeignKey("Node")]
        public Guid NodeId { get; set; }
        public Node Node { get; set; }
        #endregion
        public string Description { get; set; }
        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }
    }
}
