using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto
{
    public class ReadCertificateDto : EntityDto<Guid>
    {
        public string Type { get; set; }
        #region PlaceofIssuance
        public Guid CityId { get; set; }
        public CityDto PlaceofIssuance { get; set; }
        #endregion
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }
        public DateTime DateofIssuance { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
