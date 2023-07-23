using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto
{
    public class InsertLeaveRequestDto :EntityDto<Guid>
    {
        public Guid LeaveSettingId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double LeaveRequestBalance
        {
            get
            {
                return EndDate.Subtract(StartDate).TotalDays;
            }
        }
        public string Description { get; set; }
    }
}
