using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations
{
    public class Resignation
    {
        public DateTime ResignationDate { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        public string Description { get; set; }
    }
}
