using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers
{
    public class Transfer : FullAuditedAggregateRoot<Guid>
    {
        public JobTitle DestinationJobTitle { get; set; }
        public Position DestinationPosition { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
    }
}
