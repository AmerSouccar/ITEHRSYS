using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops
{
    public class TemporaryWorkshop : FullAuditedAggregateRoot<Guid>
    {
        #region Workshop
        [ForeignKey("Workshop")]
        public Guid WorkshopId { get; set; }
        public Workshop Workshop { get; set; }
        #endregion
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        #region TempWorkshop
        [ForeignKey("TempWorkshop")]
        public Guid TempWorkshopId { get; set; }
        public Workshop TempWorkshop { get; set; }
        #endregion

    }
}
