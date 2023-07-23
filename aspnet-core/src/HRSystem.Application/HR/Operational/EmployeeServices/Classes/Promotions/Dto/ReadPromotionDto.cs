using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto
{
    public class ReadPromotionDto :EntityDto<Guid>
    {
        public Guid JobTitleId { get; set; }
        public ReadJobTitleDto JobTitle { get; set; }
        public Guid PositionId { get; set; }
        public ReadPositionDto Position { get; set; }
        public Guid EmployeeCardId { get; set; }
        //public ReadEmployeeCardDto EmployeeCard { get; set; }
        public DateTime PromotionDate { get; set; }
        public string Description { get; set; }
    }
}
