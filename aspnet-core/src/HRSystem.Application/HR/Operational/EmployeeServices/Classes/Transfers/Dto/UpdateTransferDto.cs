using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto
{
    public class UpdateTransferDto :EntityDto<Guid>
    {
        public Guid DestinationJobTitleId { get; set; }
        public Guid DestinationPositionId { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
    }
}
