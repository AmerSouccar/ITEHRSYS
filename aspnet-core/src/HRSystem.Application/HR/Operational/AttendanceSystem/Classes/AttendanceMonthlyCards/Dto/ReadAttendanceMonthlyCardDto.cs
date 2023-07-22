using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto
{
    public class ReadAttendanceMonthlyCardDto :EntityDto<Guid>
    {
        //public EmployeeCard EmployeeCard { get; set; }
        public Guid EmployeeCardId { get; set; }
        public double TotalRequiredWorkHours { get; set; }
        public double ActualTotalWorkHours { get; set; }
        public bool isCalculated { get; set; }
    }
}
