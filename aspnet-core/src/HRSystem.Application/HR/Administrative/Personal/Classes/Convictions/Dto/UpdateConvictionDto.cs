using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto
{
    public class UpdateConvictionDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public string Number { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool isConvicted { get; set; }
        public string Notes { get; set; }
    }
}
