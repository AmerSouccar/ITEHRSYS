using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports
{
    public class Passport : FullAuditedAggregateRoot<Guid>
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public City PlaceofIssuance { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
