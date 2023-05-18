using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRSystem.Authorization.Roles;
using HRSystem.Authorization.Users;
using HRSystem.MultiTenancy;
using HRSystem.HR.Administrative.Classes.Employees;
using HRSystem.HR.Administrative.Classes.Attachments;
using HRSystem.HR.Administrative.Classes.Certificates;
using HRSystem.HR.Administrative.Classes.Childrens;
using HRSystem.HR.Administrative.Classes.Dependents;
using HRSystem.HR.Administrative.Classes.Educations;
using HRSystem.HR.Administrative.Classes.Experiences;
using HRSystem.HR.Administrative.Classes.Languages;
using HRSystem.HR.Administrative.Classes.Passports;
using HRSystem.HR.Administrative.Classes.Residences;
using HRSystem.HR.Administrative.Classes.Skills;
using HRSystem.HR.Administrative.Classes.Spouses;
using HRSystem.HR.Administrative.Classes.Trainings;
using HRSystem.HR.Administrative.Indexes.Cities;
using HRSystem.HR.Administrative.Indexes.Countries;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.EducationMajors;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.EducationTypes;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Ranks;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Scores;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.ScoreTypes;
using HRSystem.HR.Administrative.Indexes.EducationIndexes.Universities;
using HRSystem.HR.Administrative.Indexes.KinshipTypes;
using HRSystem.HR.Administrative.Indexes.LanguageNames;
using HRSystem.HR.Administrative.Indexes.Levels;
using HRSystem.HR.Administrative.Indexes.Nationalities;
using HRSystem.HR.Administrative.Indexes.Religions;
using HRSystem.HR.Administrative.Classes.MilitaryServices;
using HRSystem.HR.Administrative.Classes.DriverLicenses;
using HRSystem.HR.Administrative.Indexes.DriverLicenseTypes;
using HRSystem.HR.Administrative.Classes.Convictions;

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

    }
}
