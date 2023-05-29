using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.Grades;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.Personal.Classes.Custodies;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards
{
    public class EmployeeCard : FullAuditedAggregateRoot<Guid>
    {
        public Employee Employee { get; set; }
        public string FatherName
        {
            get
            {
                return this.Employee.FatherName;
            }
        }
        public JobDescription JobDescription { get; set; }
        public Position Position { get; set; }
        public JobTitle JobTitle { get; set; }
        public Grade Grade { get; set; }
        public DateTime StartWorkingDate { get; set; }
        public DateTime EndWorkingDate { get; set; }
        public DateTime ProbationPeriodDate { get; set; }
        public ContractType ContractType { get; set; }
        public List<Custodie> Custodies { get; set; }

    }
}
