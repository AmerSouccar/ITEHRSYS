using AutoMapper;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;

namespace HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Map
{
    public class OrganizationLevelMapProfile :Profile
    {
        public OrganizationLevelMapProfile()
        {
            CreateMap<OrganizationLevel, ReadOrganizationLevelDto>();
            CreateMap<ReadOrganizationLevelDto, OrganizationLevel>();
            CreateMap<OrganizationLevel, InsertOrganizationLevelDto>();
            CreateMap<InsertOrganizationLevelDto, OrganizationLevel>();
            CreateMap<OrganizationLevel, UpdateOrganizationLevelDto>();
            CreateMap<UpdateOrganizationLevelDto, OrganizationLevel>();
        }
    }
}
