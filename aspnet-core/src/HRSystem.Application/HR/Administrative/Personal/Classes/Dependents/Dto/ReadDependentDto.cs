using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto
{
    public class ReadDependentDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        //public ReadEmployeeDto Employee { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public KinshipLevel KinshipLevel { get; set; }
        public Guid KinshipTypeId { get; set; }
        public KinshipTypeDto KinshipType { get; set; }
        public DateTime DateofBirth { get; set; }
        public Guid PlaceofBirthId { get; set; }
        public CityDto PlaceofBirth { get; set; }
        public Guid NationalityId { get; set; }
        public NationalityDto Nationality { get; set; }
        public string ContactNumber { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
