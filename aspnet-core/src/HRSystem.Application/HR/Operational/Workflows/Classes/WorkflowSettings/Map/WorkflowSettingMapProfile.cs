using AutoMapper;
using HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Map
{
    public class WorkflowSettingMapProfile :Profile
    {
        public WorkflowSettingMapProfile()
        {
            CreateMap<WorkflowSetting, ReadWorkflowSettingDto>();
            CreateMap<ReadWorkflowSettingDto, WorkflowSetting>();
            CreateMap<WorkflowSetting, InsertWorkflowSettingDto>();
            CreateMap<InsertWorkflowSettingDto, WorkflowSetting>();
            CreateMap<WorkflowSetting, UpdateWorkflowSettingDto>();
            CreateMap<UpdateWorkflowSettingDto, WorkflowSetting>();
        }
    }
}
