﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Dto
{
    public class InsertResidencyDto :EntityDto<Guid>
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public ResidencyType ResidencyType { get; set; }
        #region Nationality
        [ForeignKey("Nationality")]
        public Guid NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        #endregion
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Notes { get; set; }
    }
}