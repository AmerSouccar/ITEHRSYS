using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops
{
    public class Workshop : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        #region AttendanceForm
        [ForeignKey("AttendanceForm")]
        public Guid AttendanceFormId { get; set; }
        public AttendanceForm AttendanceForm { get; set; }
        #endregion
        public List<NormalShift> NormalShifts { get; set; }
    }
}
