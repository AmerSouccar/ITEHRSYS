﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto
{
    public class InsertChildrenDto : EntityDto<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid SpouseId { get; set; }
        public int OrderInFamily { get; set; }
        public int Gender { get; set; }
        public int MaritialStatus { get; set; }
        public bool isEmployed { get; set; }
        public bool isStudying { get; set; }
        public DateTime DateofBirth { get; set; }

        public bool DisabilityExist { get; set; }
        public Guid PlaceofBirthId { get; set; }
        public Guid NationalityId { get; set; }
        public string ResidencyNo { get; set; }
        public DateTime? ResidencExpireDate { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
