using AutoMapper;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Map
{
    public class PositionMapProfile :Profile
    {
        public PositionMapProfile()
        {
            CreateMap<Position, ReadPositionDto>();
            CreateMap<ReadPositionDto, Position>();
            CreateMap<Position, InsertPositionDto>();
            CreateMap<InsertPositionDto, Position>();
            CreateMap<Position, UpdatePositionDto>();
            CreateMap<UpdatePositionDto, Position>();
        }
    }
}
