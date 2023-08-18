using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto
{
    public class UpdateNodeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public bool IsRoot { get; set; }
        //public List<UpdateJobDescriptionDto> JobDescriptions { get; set; }
    }
}
