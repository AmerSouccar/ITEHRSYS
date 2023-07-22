using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto
{
    public class InsertAttendanceMonthlyCardDto : EntityDto<Guid>
    {
        public Guid EmployeeCardId { get; set; }
        public double TotalRequiredWorkHours { get; set; }
        public double ActualTotalWorkHours { get; set; }
        public bool isCalculated { get; set; }
    }
}
