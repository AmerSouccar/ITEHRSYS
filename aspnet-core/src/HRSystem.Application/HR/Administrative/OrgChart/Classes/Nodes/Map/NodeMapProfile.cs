using AutoMapper;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Map
{
    public class NodeMapProfile : Profile
    {
        public NodeMapProfile()
        {
            CreateMap<Node, ReadNodeDto>();
            CreateMap<ReadNodeDto, Node>();
            CreateMap<Node, InsertNodeDto>();
            CreateMap<InsertNodeDto, Node>();
            CreateMap<Node, UpdateNodeDto>();
            CreateMap<UpdateNodeDto, Node>();
        }
    }
}
