using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops
{
    public class TemporaryWorkshop : FullAuditedAggregateRoot<Guid>
    {
        public Workshop Workshop { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Workshop TempWorkshop { get; set; }

    }
}
