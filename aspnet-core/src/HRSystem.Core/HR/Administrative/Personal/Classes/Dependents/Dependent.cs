using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents
{
    public class Dependent : FullAuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public KinshipLevel KinshipLevel { get; set; }
        #region KinshipType
        [ForeignKey("KinshipType")]
        public Guid KinshipTypeId { get; set; }
        public KinshipType KinshipType { get; set; }
        #endregion
        public DateTime DateofBirth { get; set; }
        #region PlaceofBirth
        [ForeignKey("PlaceofBirth")]
        public Guid PlaceofBirthId { get; set; }
        public City PlaceofBirth { get; set; }
        #endregion
        #region Nationality
        [ForeignKey("Nationality")]
        public Guid NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        #endregion
        public string ContactNumber { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }
        public List<Attachment> Attachments { get; set; }

    }
}
