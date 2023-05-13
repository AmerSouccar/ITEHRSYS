using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Enums;
using HRSystem.HR.Administrative.Indexes.Cities;
using HRSystem.HR.Administrative.Indexes.KinshipTypes;
using HRSystem.HR.Administrative.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Dependents
{
    public class Dependent : FullAuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public KinshipLevel KinshipLevel  { get; set; }
        public KinshipType KinshipType { get; set; }
        public DateTime DateofBirth { get; set; }
        public City PlaceofBirth  { get; set; }
        public  Nationality Nationality { get; set; }
        public string ContactNumber { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }
        public List<Attachment> Attachments { get; set; }

    }
}
