using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards
{
    public class AttendanceMonthlyCard : FullAuditedAggregateRoot<Guid>
    {
        #region EmployeeCard
        [ForeignKey("EmployeeCardId")]
        public EmployeeCard EmployeeCard { get; set; }
        public Guid EmployeeCardId { get; set; }
        #endregion

        #region AttendanceRecord
        [ForeignKey("AttendanceRecordId")]
        public AttendanceRecord AttendanceRecord { get; set; }
        public Guid AttendanceRecordId { get; set; }
        #endregion

        public double TotalRequiredWorkHours { get; set; }
        public double ActualTotalWorkHours { get; set; }
        public bool isCalculated { get; set; }
    }
}
