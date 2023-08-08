using Abp.Application.Services.Dto;
using System;

namespace HRSystem.HR.Administrative.Personal.Classes.Employees.Dto
{
    public class InsertEmployeeDto : EntityDto<Guid>
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
        #region PlaceofBirth
        public Guid PlaceofBirthId { get; set; }
        #endregion
        public string DateofBirth { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Convert.ToDateTime(DateofBirth).Year;
            }
        }
        public string IdNumber { get; set; }
        #region CountryofBirth
        public Guid CountryofBirthId { get; set; }
        #endregion
        public string PersonalRecordSource { get; set; }
        public string CivilRecordPlaceAndNumber { get; set; }
        public int Gender { get; set; }
        #region Religion
        public Guid ReligionId { get; set; }
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
        #endregion
        #region SecondaryNationality
        public Guid? SecondaryNationalityId { get; set; }
        #endregion
        public int MaritialStatus { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Facebook { get; set; }
        public int BloodType { get; set; }
    }
}
