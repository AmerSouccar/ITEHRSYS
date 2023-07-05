using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.OrgChart.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto
{
    public class ReadNodeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public Guid ParentId { get; set; }
        public ReadNodeDto? Parent { get; set; }
        public string Code { get; set; }
        public bool IsRoot { get; set; }
        //public List<ReadJobDescriptionDto> JobDescriptions { get; set; }
        public List<ReadNodeDto> Childrens { get; set; }
    }
}
