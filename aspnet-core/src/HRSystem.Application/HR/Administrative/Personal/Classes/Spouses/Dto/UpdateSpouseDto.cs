using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto
{
    public class UpdateSpouseDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        #region BasicInfo
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Guid PlaceofBirthId { get; set; }
        public Guid NationalityId { get; set; }
        #endregion
        public string ResidencyNo { get; set; }
        public DateTime ResidencyExpireDate { get; set; }
        public string PassportNo { get; set; }
        public DateTime PassportExpireDate { get; set; }
        public string FirstContactNumber { get; set; }
        public string SecondContactNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int Gender { get; set; }

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
    }
}
