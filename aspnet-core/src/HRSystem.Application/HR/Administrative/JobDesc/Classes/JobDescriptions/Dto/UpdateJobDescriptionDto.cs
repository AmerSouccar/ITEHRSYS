using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto
{
    public class UpdateJobDescriptionDto :EntityDto<Guid>
    {
        public Guid JobTitleId { get; set; }
        public string Name { get; set; }
        public Guid NodeId { get; set; }
        public string Description { get; set; }
        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }
    }
}
