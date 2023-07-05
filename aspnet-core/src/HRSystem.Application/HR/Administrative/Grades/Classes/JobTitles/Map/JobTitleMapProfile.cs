using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Map
{
    public class JobTitleMapProfile :Profile
    {
        public JobTitleMapProfile()
        {
            CreateMap<JobTitle, ReadJobTitleDto>();
            CreateMap<ReadJobTitleDto, JobTitle>();
            CreateMap<JobTitle, InsertJobTitleDto>();
            CreateMap<InsertJobTitleDto, JobTitle>();
            CreateMap<JobTitle, UpdateJobTitleDto>();
            CreateMap<UpdateJobTitleDto, JobTitle>();
        }
    }
}
