using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Dto
{
    public class UpdatePassportDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Guid PlaceofIssuanceId { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
