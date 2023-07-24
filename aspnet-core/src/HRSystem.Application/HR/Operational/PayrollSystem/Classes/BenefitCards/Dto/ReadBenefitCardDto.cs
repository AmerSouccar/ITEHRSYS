using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.PayrollSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto
{
    public class ReadBenefitCardDto :EntityDto<Guid>
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Formula Formula { get; set; }
    }
}
