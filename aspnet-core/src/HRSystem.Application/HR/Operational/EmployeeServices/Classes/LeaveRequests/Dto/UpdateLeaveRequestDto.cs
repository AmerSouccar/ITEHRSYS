using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto
{
    public class UpdateLeaveRequestDto :EntityDto<Guid>
    {
        public Guid LeaveSettingId { get; set; }
        public Guid EmployeeId { get; set; }
        public string RequestDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool isHourly { get; set; }
        public string? StartHour { get; set; }
        public string? EndHour { get; set; }
        public double LeaveRequestBalance
        {
            get
            {
                if (isHourly)
                {
                    double spentHours = Convert.ToDateTime(EndDate).Subtract(Convert.ToDateTime(StartDate)).TotalHours;
                    double spentDays = spentHours / 8;
                    return spentDays;
                }
                else
                    return Convert.ToDateTime(EndDate).Subtract(Convert.ToDateTime(StartDate)).TotalDays;
            }
        }
        public string Description { get; set; }
    }
}
