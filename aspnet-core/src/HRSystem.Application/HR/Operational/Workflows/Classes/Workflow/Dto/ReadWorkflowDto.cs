using Abp.Application.Services.Dto;
using HRSystem.Authorization.Users;
using HRSystem.HR.Operational.Workflows.Enums;
using HRSystem.Users.Dto;
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
        public string Date { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public long CreatorId { get; set; }
        public UserDto Creator { get; set; }
        public long FirstUserId { get; set; }
        public UserDto? FirstUser { get; set; }
        public long CurrentUserId { get; set; }
        public UserDto? CurrentUser { get; set; }
        public long TargetUserId { get; set; }
        public UserDto? TargetUser { get; set; }
    }
}
