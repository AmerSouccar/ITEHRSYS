using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Enums;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions
{
    public class Position : FullAuditedAggregateRoot<Guid>
    {
        public JobDescription JobDescription { get; set; }
        public PositionWorkType PositionWorkType { get; set; }
        public double WorkingHours { get; set; }
        public HoursPer Per { get; set; }
        public bool HasManager { get; set; }
        public JobTitle? ManagerJobTitle { get; set; }
        public JobDescription? Manager { get; set; }

        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }
    }
}
