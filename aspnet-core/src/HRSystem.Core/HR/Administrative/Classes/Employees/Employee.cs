using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Classes.Certificates;
using HRSystem.HR.Administrative.Classes.Childrens;
using HRSystem.HR.Administrative.Classes.Dependents;
using HRSystem.HR.Administrative.Classes.Educations;
using HRSystem.HR.Administrative.Classes.Experiences;
using HRSystem.HR.Administrative.Classes.Languages;
using HRSystem.HR.Administrative.Classes.Passports;
using HRSystem.HR.Administrative.Classes.Residences;
using HRSystem.HR.Administrative.Classes.Skills;
using HRSystem.HR.Administrative.Classes.Spouses;
using HRSystem.HR.Administrative.Classes.Trainings;
using HRSystem.HR.Administrative.Enums;
using HRSystem.HR.Administrative.Indexes.Cities;
using HRSystem.HR.Administrative.Indexes.Countries;
using HRSystem.HR.Administrative.Indexes.Nationalities;
using HRSystem.HR.Administrative.Indexes.Religions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HRSystem.HR.Administrative.Classes.Employees
{
    public class Employee : FullAuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }

        }
        public string TripleName
        {
            get
            {
                return FirstName + " " + FatherName + "" + LastName;
            }

        }
        public City PlaceofBirth { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age 
        {
            get
            {
                return DateTime.Now.Year - DateofBirth.Year;
            }
        }
        public string IdNumber { get; set; }
        public Country CountryofBirth { get; set; }
        public string PersonalRecordSource { get; set; }
        public string CivilRecordPlaceAndNumber { get; set; }
        public Gender Gender { get; set; }
        public Religion Religion { get; set; }
        public string? FirstNameAr { get; set; }
        public string? LastNameAr { get; set; }
        public string? FatherNameAr { get; set; }
        public string? MotherNameAr { get; set; }
        public string FullNameAr
        {
            get
            {
                return FirstNameAr + " " + LastNameAr;
            }

        }
        public string TripleNameAr
        {
            get
            {
                return FirstNameAr + " " + FatherNameAr + "" + LastNameAr;
            }

        }
        public string? PlaceofBirthAr { get; set; }
        public Nationality Nationality { get; set; }
        public Nationality? SecondaryNationality { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        public string PhotoPath { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? WebSite { get; set; }
        public string? Facebook { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<Spouse> Spouse { get; set; }
        public List<Children> Children { get; set; }
        public List<Dependent> Dependents { get; set; }
        public List<Education> Educations { get; set; }
        public List<Training> Trainings { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Language> Languages { get; set; }
        public List<Certificate> Certificates { get; set; }
        //public List<MilitaryService> MilitaryService { get; set; }
        public List<Passport> Passports { get; set; }
        //public List<DriverLicense> DriverLicense { get; set; }
        //public List<Conviction> Convictions { get; set; }
        public List<Residency> Residences { get; set; }
        //public List<Position> Positions { get; set; }       
        //public List<PositionLog> LogOfPosition { get; set; }
        public BloodType BloodType { get; set; }

    }
}
