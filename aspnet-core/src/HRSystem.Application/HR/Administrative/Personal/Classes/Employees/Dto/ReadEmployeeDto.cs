using Abp.Application.Services.Dto;
using HRSystem.Authorization.Users;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Childrens;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Convictions;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Dependents;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Experiences;
using HRSystem.HR.Administrative.Personal.Classes.Experiences.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Languages;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Passports;
using HRSystem.HR.Administrative.Personal.Classes.Passports.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Residences;
using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Skills;
using HRSystem.HR.Administrative.Personal.Classes.Skills.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Spouses;
using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Trainings.Dto;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Cities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using HRSystem.HR.Administrative.Personal.Indexes.Countries.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Religions;
using HRSystem.HR.Administrative.Personal.Indexes.Religions.Dto;
using HRSystem.Users.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Dto
{
    public class ReadEmployeeDto : EntityDto<Guid>
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
                return FirstName + " " + FatherName + " " + LastName;
            }

        }
        #region PlaceofBirth
        public Guid PlaceofBirthId { get; set; }
        public CityDto PlaceofBirth { get; set; }
        #endregion
        public DateTime DateofBirth { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateofBirth.Year;
            }
        }
        public string IdNumber { get; set; }
        #region CountryofBirth
        public Guid CountryofBirthId { get; set; }
        public CountryDto CountryofBirth { get; set; }
        #endregion
        public string PersonalRecordSource { get; set; }
        public string CivilRecordPlaceAndNumber { get; set; }
        public int Gender { get; set; }
        #region Religion
        public Guid ReligionId { get; set; }
        public ReligionDto Religion { get; set; }
        #endregion
        public string FirstNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FatherNameAr { get; set; }
        public string MotherNameAr { get; set; }
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
        public string PlaceofBirthAr { get; set; }
        #region Nationality
        public Guid NationalityId { get; set; }
        public NationalityDto Nationality { get; set; }
        #endregion
        #region SecondaryNationality
        public Guid SecondaryNationalityId { get; set; }
        public NationalityDto? SecondaryNationality { get; set; }
        #endregion
        public int MaritialStatus { get; set; }
        public string PhotoPath { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Facebook { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
        public List<ReadSpouseDto> Spouse { get; set; }
        public List<ReadChildrenDto> Children { get; set; }
        public List<ReadDependentDto> Dependents { get; set; }
        public List<ReadEducationDto> Educations { get; set; }
        public List<ReadTrainingDto> Trainings { get; set; }
        public List<ReadExperienceDto> Experiences { get; set; }
        public List<ReadSkillDto> Skills { get; set; }
        public List<ReadLanguageDto> Languages { get; set; }
        public List<ReadCertificateDto> Certificates { get; set; }
        public List<ReadMilitaryServiceDto> MilitaryService { get; set; }
        public List<ReadPassportDto> Passports { get; set; }
        public List<ReadDriverLicenseDto> DriverLicense { get; set; }
        public List<ReadConvictionDto> Convictions { get; set; }
        public List<ReadResidencyDto> Residences { get; set; }
        public List<ReadPositionDto> Positions { get; set; }
        //public List<PositionLog> LogOfPosition { get; set; }
        public int BloodType { get; set; }
        #region User
        public long UserId { get; set; }
        public UserDto? User { get; set; }
        #endregion
    }
}
