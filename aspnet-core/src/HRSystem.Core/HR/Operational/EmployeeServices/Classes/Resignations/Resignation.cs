using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations
{
    public class Resignation
    {
        public DateTime ResignationDate { get; set; }
        #region EmployeeCard
        [ForeignKey("EmployeeCard")]
        public Guid EmployeeCardId { get; set; }
        public EmployeeCard EmployeeCard { get; set; }
        #endregion
        public string Description { get; set; }
    }
}
