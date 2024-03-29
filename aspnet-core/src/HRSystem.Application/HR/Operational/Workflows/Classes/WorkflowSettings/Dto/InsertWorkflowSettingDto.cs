﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto
{
    public class InsertWorkflowSettingDto :EntityDto<Guid>
    {
        public int Title { get; set; }
        public int Steps { get; set; }
    }
}
