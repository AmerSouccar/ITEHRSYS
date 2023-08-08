using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto
{
    public class InsertCertificateDto : EntityDto<Guid>
    {
        public string Type { get; set; }
        public Guid CityId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime DateofIssuance { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
    }
}
