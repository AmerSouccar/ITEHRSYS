using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto
{
    public class UpdatePromotionDto :EntityDto<Guid>
    {
        public Guid JobTitleId { get; set; }
        public Guid PositionId { get; set; }
        public Guid EmployeeCardId { get; set; }
        public DateTime PromotionDate { get; set; }
        public string Description { get; set; }
    }
}
