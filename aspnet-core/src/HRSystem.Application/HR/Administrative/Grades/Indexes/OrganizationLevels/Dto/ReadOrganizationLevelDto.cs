using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto
{
    public class ReadOrganizationLevelDto :EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
