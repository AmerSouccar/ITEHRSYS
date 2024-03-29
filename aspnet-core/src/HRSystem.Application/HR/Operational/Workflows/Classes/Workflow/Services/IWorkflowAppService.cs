﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.Workflows.Classes.Workflow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.Workflows.Classes.Workflow.Services
{
    public interface IWorkflowAppService : IApplicationService
    {
        public Task<List<ReadWorkflowDto>> GetAll();
        public Task<ReadWorkflowDto> GetbyId(Guid id);
        public Task<InsertWorkflowDto> Insert(InsertWorkflowDto workflow);
        public Task<UpdateWorkflowDto> Update(UpdateWorkflowDto workflow);
        public Task Delete(Guid id);
    }
}
