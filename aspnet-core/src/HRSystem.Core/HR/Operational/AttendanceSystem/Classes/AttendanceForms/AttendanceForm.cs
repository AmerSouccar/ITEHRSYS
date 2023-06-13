using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms
{
    public class AttendanceForm : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public List<Workshop> Workshops { get; set; }
    }
}
