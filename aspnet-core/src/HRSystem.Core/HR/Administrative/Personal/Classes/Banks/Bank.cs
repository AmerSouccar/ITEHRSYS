using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks
{
    public class Bank : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        #region Nationality
        public Guid NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        #endregion
        public string PhoneNumber { get; set; }
    }
}
