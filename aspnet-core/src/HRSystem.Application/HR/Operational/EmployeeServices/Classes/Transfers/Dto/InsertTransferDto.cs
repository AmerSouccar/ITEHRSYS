using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto
{
    public class InsertTransferDto :EntityDto<Guid>
    {
        public Guid DestinationJobTitleId { get; set; }
        public Guid DestinationPositionId { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
    }
}
