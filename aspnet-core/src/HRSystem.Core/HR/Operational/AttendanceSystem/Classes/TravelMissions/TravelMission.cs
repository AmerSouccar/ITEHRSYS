using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Operational.AttendanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions
{
    public class TravelMission : FullAuditedAggregateRoot<Guid>
    {
        public Employee Employee { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Notes { get; set; }
        public bool isTransferd { get; set; }
        public Status Status { get; set; }
    }
}
