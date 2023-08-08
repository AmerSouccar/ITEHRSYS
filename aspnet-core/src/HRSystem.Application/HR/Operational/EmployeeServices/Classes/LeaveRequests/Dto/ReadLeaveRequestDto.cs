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
