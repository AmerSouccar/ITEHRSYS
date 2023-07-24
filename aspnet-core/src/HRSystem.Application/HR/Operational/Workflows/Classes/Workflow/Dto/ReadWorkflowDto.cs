using Abp.Application.Services.Dto;
using HRSystem.Authorization.Users;
using HRSystem.HR.Operational.Workflows.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto
{
    public class ReadWorkflowDto :EntityDto<Guid>
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public WorkflowStatus Status { get; set; }
        public WorkflowType Type { get; set; }
        public long CreatorId { get; set; }
        //public ReadUserDto Creator { get; set; }
        public long FirstUserId { get; set; }
        //public ReadUserDto? FirstUser { get; set; }
        public long CurrentUserId { get; set; }
        //public ReadUserDto? CurrentUser { get; set; }
        public long TargetUserId { get; set; }
        //public ReadUserDto? TargetUser { get; set; }
    }
}
