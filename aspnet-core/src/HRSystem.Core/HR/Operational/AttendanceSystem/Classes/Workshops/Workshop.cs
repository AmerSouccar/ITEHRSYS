using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops
{
    public class Workshop : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public List<NormalShift> NormalShifts { get; set; }
    }
}
