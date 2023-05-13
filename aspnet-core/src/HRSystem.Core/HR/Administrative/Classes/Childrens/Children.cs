using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Spouses;
using HRSystem.HR.Administrative.Enums;
using HRSystem.HR.Administrative.Indexes.Cities;
using HRSystem.HR.Administrative.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Childrens
{
    public class Children :FullAuditedAggregateRoot<Guid>

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Spouse Spouse { get; set; }
        public int OrderInFamily { get; set; }
        public Gender Gender { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        public bool isEmployed { get; set; }
        public bool isStudying { get; set; }
        public DateTime DateofBirth { get; set; }

        public bool DisabilityExist { get; set; }

        public City PlaceofBirth { get; set; }
        public Nationality Nationality { get; set; }
        public string ResidencyNo { get; set; }
        public string ResidencExpireDate { get; set; }
        public string PassportNo { get; set; }
        public string PassportExpireDate { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }

    }
}
