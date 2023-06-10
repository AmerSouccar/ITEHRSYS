using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions
{
    public class Promotion : FullAuditedAggregateRoot<Guid>
    {
        public JobTitle JobTitle { get; set; }
        public Position Position { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        public DateTime PromotionDate { get; set; }
        public string Description { get; set; }
    }
}
