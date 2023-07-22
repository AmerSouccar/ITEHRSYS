using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto
{
    public class ReadTemporaryWorkshopDto :EntityDto<Guid>
    {
        public Guid WorkshopId { get; set; }
        //public ReadWorkshopDto Workshop { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Guid TempWorkshopId { get; set; }
        //public ReadWorkshopDto TempWorkshop { get; set; }

    }
}
