using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests.Dto
{
    public class ReadLeaveRequestDto : EntityDto<Guid>
    {
        public Guid LeaveSettingId { get; set; }
        public ReadLeaveSettingDto LeaveSetting { get; set; }
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }

        public string RequestDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool isHourly { get; set; }
        public string? StartHour { get; set; }
        public string? EndHour { get; set; }
        public int LeaveRequestStatus { get; set; }

        public double LeaveRequestBalance
        {
            get
            {
                if (isHourly)
                {
                    double spentHours = Convert.ToDateTime(EndHour).Subtract(Convert.ToDateTime(StartHour)).TotalHours;
                    double spentDays = spentHours / 8;
                    return spentDays;
                }
                else
                    return Convert.ToDateTime(EndDate).Subtract(Convert.ToDateTime(StartDate)).TotalDays + 1;
            }
        }
        public string Description { get; set; }
    }
}
