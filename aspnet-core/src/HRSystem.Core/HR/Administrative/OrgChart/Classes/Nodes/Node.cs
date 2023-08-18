using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.OrgChart.Enums;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes
{
    public class Node : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public NodeType Type { get; set; }
        #region Parent
        [ForeignKey("Parent")]
        public Guid? ParentId { get; set; }
        public Node? Parent { get; set; }
        #endregion
        public string Code { get; set; }
        public bool IsRoot { get; set; }
        public List<JobDescription> JobDescriptions { get; set; }
        public List<Node> Childrens { get; set; }

    }
}
