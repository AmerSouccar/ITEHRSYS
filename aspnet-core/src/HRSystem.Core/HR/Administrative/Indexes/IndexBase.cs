using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Indexes
{
    public class IndexBase : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
