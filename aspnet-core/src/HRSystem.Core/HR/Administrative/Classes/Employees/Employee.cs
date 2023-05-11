using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Classes.Employees
{
    public class Employee : FullAuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirtNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; }
        public City PlaceofBirth { get; set; }
        public string Description { get; set; }
        public string FullName {
            get
            {
                return FirstName + " " + LastName;
            }
                
                }
    }
}
