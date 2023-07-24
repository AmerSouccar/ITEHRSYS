using AutoMapper;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Map
{
    public class WorkflowMapProfile :Profile
    {
        public WorkflowMapProfile()
        {
            CreateMap<Workflow, ReadWorkflowDto>();
            CreateMap<ReadWorkflowDto, Workflow>();
            CreateMap<Workflow, InsertWorkflowDto>();
            CreateMap<InsertWorkflowDto, Workflow>();
            CreateMap<Workflow, UpdateWorkflowDto>();
            CreateMap<UpdateWorkflowDto, Workflow>();
        }
    }
}
