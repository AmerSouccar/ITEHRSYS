using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto
{
    public class ReadDriverLicenseDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        //public ReadEmployeeDto Employee { get; set; }
        public string Number { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LegalCondition { get; set; }
        public Guid DriverLicenseTypeId { get; set; }
        public DriverLicenseTypeDto DriverLicenseType { get; set; }
        public Guid PlaceofIssuanceId { get; set; }
        public CityDto PlaceofIssuance { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
