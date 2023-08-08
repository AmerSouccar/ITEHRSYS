using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto
{
    public class InsertPositionWorkTypeDto :EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
