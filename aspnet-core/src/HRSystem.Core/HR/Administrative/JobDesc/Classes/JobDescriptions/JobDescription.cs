using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.Registration;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions
{
    public class JobDescription : FullAuditedAggregateRoot<Guid>
    {
        public JobTitle JobTitle { get; set; }
        public string Name { get; set; }
        public Node Node { get; set; }
        public string Description { get; set; }
        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }
    }
}
