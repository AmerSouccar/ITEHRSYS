﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto
{
    public class InsertAssignmentDto :EntityDto<Guid>
    {
        public Guid JobTitleId { get; set; }
        public Guid PositionID { get; set; }

        public Guid EmployeeCardId { get; set; }
        public DateTime AssigningDate { get; set; }
        public string Description { get; set; }
    }
}
