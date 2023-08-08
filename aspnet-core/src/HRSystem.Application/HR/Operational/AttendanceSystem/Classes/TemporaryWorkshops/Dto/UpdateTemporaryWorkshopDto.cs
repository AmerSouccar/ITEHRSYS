using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto
{
    public class UpdateTemporaryWorkshopDto :EntityDto<Guid>
    {
        public Guid WorkshopId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Guid TempWorkshopId { get; set; }
    }
}
