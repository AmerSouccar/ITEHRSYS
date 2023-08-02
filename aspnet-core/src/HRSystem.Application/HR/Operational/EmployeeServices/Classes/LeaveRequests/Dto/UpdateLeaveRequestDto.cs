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
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isHourly { get; set; }
        public DateTime? StartHour { get; set; }
        public DateTime? EndHour { get; set; }
        public double LeaveRequestBalance
        {
            get
            {
                if (isHourly)
                {
                    double spentHours = EndDate.Subtract(StartDate).TotalHours;
                    double spentDays = spentHours / 8;
                    return spentDays;
                }
                else
                    return EndDate.Subtract(StartDate).TotalDays;
            }
        }
        public string Description { get; set; }
    }
}
