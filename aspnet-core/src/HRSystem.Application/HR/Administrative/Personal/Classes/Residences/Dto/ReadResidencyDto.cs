using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Dto
{
    public class ReadResidencyDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }

        public string Number { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public ResidencyType ResidencyType { get; set; }
        public Guid NationalityId { get; set; }
        public NationalityDto Nationality { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Notes { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
