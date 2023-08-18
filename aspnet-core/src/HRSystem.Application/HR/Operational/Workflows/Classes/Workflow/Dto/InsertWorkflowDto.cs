using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.Workflows.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto
{
    public class InsertWorkflowDto :EntityDto<Guid>
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public long CreatorId { get; set; }
        public long FirstUserId { get; set; }
        public long CurrentUserId { get; set; }
        public long TargetUserId { get; set; }
    }
}
