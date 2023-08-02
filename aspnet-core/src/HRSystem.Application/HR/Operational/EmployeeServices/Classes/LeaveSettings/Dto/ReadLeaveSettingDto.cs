using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto
{
    public class ReadLeaveSettingDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public bool isPaidLeave { get; set; }
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }
        public Guid WorkflowSettingId { get; set; }
        public ReadWorkflowSettingDto WorkflowSetting { get; set; }
        public string Description { get; set; }
    }
}
