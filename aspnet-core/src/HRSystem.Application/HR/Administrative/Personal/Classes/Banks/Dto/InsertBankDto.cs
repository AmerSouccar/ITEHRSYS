using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Dto
{
    public class InsertBankDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public Guid NationalityId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
