using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Enums;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto
{
    public class InsertPositionDto :EntityDto<Guid>
    {
        public Guid JobDescriptionId { get; set; }
        public Guid PositionWorkTypeId { get; set; }
        public double WorkingHours { get; set; }
        public int Per { get; set; }
        public bool HasManager { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
