using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto
{
    public class InsertPromotionDto :EntityDto<Guid>
    {
        public Guid JobTitleId { get; set; }
        public Guid PositionId { get; set; }
        public Guid EmployeeCardId { get; set; }
        public DateTime PromotionDate { get; set; }
        public string Description { get; set; }
    }
}
