using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Attachments.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Employees.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Dto
{
    public class ReadExperienceDto :EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        public ReadEmployeeDto Employee { get; set; }

        public string JobTitle { get; set; }
        public string Industry { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyWebSite { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LeaveReason { get; set; }
        public string Notes { get; set; }
        public string ReferenceFullName { get; set; }
        public string ReferenceJobTitle { get; set; }
        public string ReferenceContact { get; set; }
        public string ReferenceEmail { get; set; }
        public List<ReadAttachmentDto> Attachments { get; set; }
    }
}
