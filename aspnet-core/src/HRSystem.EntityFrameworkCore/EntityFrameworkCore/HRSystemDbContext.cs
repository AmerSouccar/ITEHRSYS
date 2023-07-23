using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRSystem.Authorization.Roles;
using HRSystem.Authorization.Users;
using HRSystem.MultiTenancy;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using HRSystem.HR.Administrative.Personal.Indexes.Countries;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Scores;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.ScoreTypes;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Universities;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Personal.Indexes.Levels;
using HRSystem.HR.Administrative.Personal.Indexes.Nationalities;
using HRSystem.HR.Administrative.Personal.Indexes.Religions;
using HRSystem.HR.Administrative.Personal.Classes.Attachments;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using HRSystem.HR.Administrative.Personal.Classes.Childrens;
using HRSystem.HR.Administrative.Personal.Classes.Convictions;
using HRSystem.HR.Administrative.Personal.Classes.Dependents;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses;
using HRSystem.HR.Administrative.Personal.Classes.Educations;
using HRSystem.HR.Administrative.Personal.Classes.Employees;
using HRSystem.HR.Administrative.Personal.Classes.Experiences;
using HRSystem.HR.Administrative.Personal.Classes.Languages;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices;
using HRSystem.HR.Administrative.Personal.Classes.Passports;
using HRSystem.HR.Administrative.Personal.Classes.Residences;
using HRSystem.HR.Administrative.Personal.Classes.Skills;
using HRSystem.HR.Administrative.Personal.Classes.Spouses;
using HRSystem.HR.Administrative.Personal.Classes.Trainings;
using HRSystem.HR.Administrative.Personal.Classes.BankInformations;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using HRSystem.HR.Administrative.Personal.Classes.Custodies;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades;
using HRSystem.HR.Administrative.Grades.Classes.Grades;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays;
using HRSystem.HR.Operational.EmployeeServices.Classes.CompanyHolidays;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveRequests;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.DeductionCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.FinancialCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months;
using HRSystem.HR.Operational.Workflows.Classes.Workflow;
using HRSystem.HR.Operational.Workflows.Classes.WorkflowSettings;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels;

namespace HRSystem.EntityFrameworkCore
{
    public class HRSystemDbContext : AbpZeroDbContext<Tenant, Role, User, HRSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRSystemDbContext(DbContextOptions<HRSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> HRLanguages { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Residency> Residencies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spouse> Spouses { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EducationMajor> EducationMajors { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<ScoreType> ScoreTypes { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<KinshipType> KinshipTypes { get; set; }
        public DbSet<LanguageName> LanguageNames { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<MilitaryService> MilitaryServices { get; set; }
        public DbSet<DriverLicense> DriverLicenses { get; set; }
        public DbSet<DriverLicenseType> DriverLicenseTypes { get; set; }
        public DbSet<Conviction> Convictions { get; set; }
        public DbSet<BankInformation> BankInformations { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Custodie> Custodies { get; set; }
        public DbSet<ReadEmployeeCardDto> EmployeeCards { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionWorkType> PositionWorkTypes { get; set; }
        public DbSet<EducationGrade> EducationGrades { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }



        //Ops

        public DbSet<AttendanceForm> AttendanceForms { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<EntranceExitRecord> EntranceExitRecords { get; set; }
        public DbSet<HourlyMission> HourlyMissions { get; set; }
        public DbSet<NormalShift> NormalShifts { get; set; }
        public DbSet<TemporaryWorkshop> TemporaryWorkshops { get; set; }
        public DbSet<TravelMission> TravelMissions { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<ChangeableHoliday> ChangeableHolidays { get; set; }
        public DbSet<CompanyHoliday> CompanyHolidays { get; set; }
        public DbSet<FixedHoliday> FixedHolidays { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveSetting> LeaveSettings { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Resignation> Resignations { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<BenefitCard> BenefitCards { get; set; }
        public DbSet<DeductionCard> DeductionCards { get; set; }
        public DbSet<FinancialCard> FinancialCards { get; set; }
        public DbSet<MonthlyCard> MonthlyCards { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Workflow> Workflows { get; set; }
        public DbSet<WorkflowSetting> WorkflowSettings { get; set; }
        public DbSet<AttendanceMonthlyCard> AttendanceMonthlyCards { get; set; }
        public DbSet<Node> Nodes { get; set; }

        public DbSet<OrganizationLevel> OrganizationLevels { get;set; }


    }
}
