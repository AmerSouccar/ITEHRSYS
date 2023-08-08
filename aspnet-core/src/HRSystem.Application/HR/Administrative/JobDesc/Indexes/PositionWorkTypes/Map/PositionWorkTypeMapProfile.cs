using AutoMapper;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Map
{
    public class PositionWorkTypeMapProfile :Profile
    {
        public PositionWorkTypeMapProfile()
        {
            CreateMap<PositionWorkType, ReadPositionWorkTypeDto>();
            CreateMap<ReadPositionWorkTypeDto, PositionWorkType>();
            CreateMap<PositionWorkType, InsertPositionWorkTypeDto>();
            CreateMap<InsertPositionWorkTypeDto, PositionWorkType>();
            CreateMap<PositionWorkType, UpdatePositionWorkTypeDto>();
            CreateMap<UpdatePositionWorkTypeDto, PositionWorkType>();
        }
    }
}
