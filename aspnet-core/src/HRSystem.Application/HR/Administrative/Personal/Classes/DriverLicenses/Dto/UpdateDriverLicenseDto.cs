using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto
{
    public class UpdateDriverLicenseDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public string Number { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LegalCondition { get; set; }
        public Guid DriverLicenseTypeId { get; set; }
        public Guid PlaceofIssuanceId { get; set; }
    }
}

