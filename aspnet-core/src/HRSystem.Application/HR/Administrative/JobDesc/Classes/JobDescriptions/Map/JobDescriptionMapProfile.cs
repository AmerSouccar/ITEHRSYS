using AutoMapper;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Map
{
    public class JobDescriptionMapProfile:Profile
    {
        public JobDescriptionMapProfile()
        {
            CreateMap<JobDescription, ReadJobDescriptionDto>();
            CreateMap<ReadJobDescriptionDto, JobDescription>();
            CreateMap<JobDescription, InsertJobDescriptionDto>();
            CreateMap<InsertJobDescriptionDto, JobDescription>();
            CreateMap<JobDescription, UpdateJobDescriptionDto>();
            CreateMap<UpdateJobDescriptionDto, JobDescription>();
        }
    }
}
