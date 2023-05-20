using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.OrgChart.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes
{
    public class Node : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public NodeType Type { get; set; }
        public Node? Parent { get; set; }
        public string Code { get; set; }
        public bool IsRoot { get; set; }
        //public List<JobDescription> JobDescriptions { get; set; }
        public List<Node> Childrens { get; set; }

        //Add Benefits And Deductions


    }
}
