using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Indexes.Cities;
using HRSystem.HR.Administrative.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.DriverLicenses
{
    public class DriverLicense : FullAuditedAggregateRoot<Guid>
    {
        public string Number { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LegalCondition { get; set; }
        public DriverLicenseType DriverLicenseType { get; set; }
        public City PlaceofIssuance { get; set; }
        public List<Attachment> Attachments { get; set; }

    }
}
