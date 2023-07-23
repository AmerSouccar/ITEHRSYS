using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto
{
    public class UpdateResignationDto :EntityDto<Guid>
    {
        public DateTime ResignationDate { get; set; }
        public Guid EmployeeCardId { get; set; }
        public string Description { get; set; }
    }
}
