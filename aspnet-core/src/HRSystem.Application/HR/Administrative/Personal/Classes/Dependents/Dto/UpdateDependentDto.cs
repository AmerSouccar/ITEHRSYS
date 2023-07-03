using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto
{
    public class UpdateDependentDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public KinshipLevel KinshipLevel { get; set; }
        public Guid KinshipTypeId { get; set; }
        public DateTime DateofBirth { get; set; }
        public Guid PlaceofBirthId { get; set; }
        public Guid NationalityId { get; set; }
        public string ContactNumber { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
