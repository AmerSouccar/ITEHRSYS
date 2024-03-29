﻿using Abp.Domain.Entities.Auditing;
using HRSystem.HR.Administrative.Grades.Classes.Grades;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.Personal.Classes.Custodies;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Enums;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards
{
    public class EmployeeCard : FullAuditedAggregateRoot<Guid>
    {
        #region Employee
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        #endregion
        public string FatherName
        {
            get
            {
                return this.Employee.FatherName;
            }
        }
        #region JobDescription
        [ForeignKey("JobDescription")]
        public Guid? JobDescriptionId { get; set; }
        public JobDescription? JobDescription { get; set; }
        #endregion
        #region Position
        [ForeignKey("Position")]
        public Guid? PositionId { get; set; }
        public Position? Position { get; set; }
        #endregion
        #region JobTitle
        [ForeignKey("JobTitle")]
        public Guid? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
        #endregion
        #region Grade
        [ForeignKey("Grade")]
        public Guid? GradeId { get; set; }
        public Grade? Grade { get; set; }
        #endregion
        #region AttendanceForm
        [ForeignKey("AttendanceForm")]
        public Guid? AttendanceFormId { get; set; }
        public AttendanceForm? AttendanceForm { get; set; }
        #endregion
        public DateTime StartWorkingDate { get; set; }
        public DateTime EndWorkingDate { get; set; }
        public DateTime ProbationPeriodDate { get; set; }
        public ContractType ContractType { get; set; }
        public List<Custodie> Custodies { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Transfer> Transfers { get; set; }
        public List<Resignation> Resignations { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; }
        //add bank information

    }
}
