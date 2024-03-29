﻿using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses
{
    public class DriverLicense : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public string Number { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LegalCondition { get; set; }
        #region DriverLicenseType
        [ForeignKey("DriverLicenseType")]
        public Guid DriverLicenseTypeId { get; set; }
        public DriverLicenseType DriverLicenseType { get; set; }
        #endregion
        #region PlaceofIssuance
        [ForeignKey("PlaceofIssuance")]
        public Guid PlaceofIssuanceId { get; set; }
        public City PlaceofIssuance { get; set; }
        #endregion
        public List<Attachment> Attachments { get; set; }
    }
}
