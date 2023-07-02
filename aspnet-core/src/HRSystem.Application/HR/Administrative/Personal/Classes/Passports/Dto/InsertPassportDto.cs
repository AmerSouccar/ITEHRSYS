using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Dto
{
    public class InsertPassportDto : EntityDto<Guid>
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        #region PlaceofIssuance
        [ForeignKey("PlaceofIssuance")]
        public Guid PlaceofIssuanceId { get; set; }
        public City PlaceofIssuance { get; set; }
        #endregion
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
