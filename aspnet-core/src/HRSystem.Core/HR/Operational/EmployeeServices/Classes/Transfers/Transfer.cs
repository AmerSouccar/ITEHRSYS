using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers
{
    public class Transfer : FullAuditedAggregateRoot<Guid>
    {
        #region DestinationJobTitle
        [ForeignKey("DestinationJobTitle")]
        public Guid DestinationJobTitleId { get; set; }
        public JobTitle DestinationJobTitle { get; set; }
        #endregion
        #region DestinationPosition
        [ForeignKey("DestinationPosition")]
        public Guid DestinationPositionId { get; set; }
        public Position DestinationPosition { get; set; }
        #endregion
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
    }
}
