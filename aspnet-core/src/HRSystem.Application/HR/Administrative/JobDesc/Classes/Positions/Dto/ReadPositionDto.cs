using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;
using HRSystem.HR.Administrative.JobDesc.Enums;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto
{
    public class ReadPositionDto :EntityDto<Guid>
    {
        #region JobDescription
        public Guid JobDescriptionId { get; set; }
        public ReadJobDescriptionDto JobDescription { get; set; }
        #endregion
        #region PositionWorkType
        public Guid PositionWorkTypeId { get; set; }
        public ReadPositionWorkTypeDto PositionWorkType { get; set; }
        #endregion
        public double WorkingHours { get; set; }
        public HoursPer Per { get; set; }
        public bool HasManager { get; set; }
     
        #region Manager
        public Guid? ManagerId { get; set; }
        public ReadPositionDto? Manager { get; set; }
        #endregion
    }
}
