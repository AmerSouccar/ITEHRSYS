﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto
{
    public class ReadJobTitleDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public int EmployeeCount { get; set; }
        public string Description { get; set; }

        //public List<BenefitCard> BenefitCards { get; set; }
        //public List<DeductionCard> DeductionCards { get; set; }

    }
}
