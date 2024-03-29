﻿using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses
{
    public class Spouse : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        #region BasicInfo
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
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
        public string ResidencyNo { get; set; }
        public DateTime ResidencyExpireDate { get; set; }
        public string PassportNo { get; set; }
        public DateTime PassportExpireDate { get; set; }
        public string FirstContactNumber { get; set; }
        public string SecondContactNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Gender Gender { get; set; }
        #endregion

        #region MarrigeInfo
        public int Order { get; set; }
        public DateTime MarrigeDate { get; set; }
        public bool isDivorced { get; set; }
        public DateTime? DivorceDate { get; set; }
        public bool isDead { get; set; }
        public DateTime? DeathDate { get; set; }

        #endregion
        #region JobInfo
        public bool HasJob { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string WorkAddress { get; set; }
        public string WorkPhone { get; set; }
        public string WorkEmail { get; set; }

        #endregion
        public List<Attachment> Attachments { get; set; }
    }
}
