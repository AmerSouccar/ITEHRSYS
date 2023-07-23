using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto
{
    public class ReadResignationDto :EntityDto<Guid>
    {
        public DateTime ResignationDate { get; set; }
        public Guid EmployeeCardId { get; set; }
        public ReadEmployeeCardDto EmployeeCard { get; set; }
        public string Description { get; set; }
    }
}
