using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto
{
    public class ReadWorkflowSettingDto :EntityDto<Guid>
    {
        public string Title { get; set; }
        public int Steps { get; set; }
    }
}
