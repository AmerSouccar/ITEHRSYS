using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Map
{
    public class ChildrenMapProfile : Profile
    {
        public ChildrenMapProfile()
        {
            CreateMap<Children, ReadChildrenDto>();
            CreateMap<ReadChildrenDto, Children>();
            CreateMap<Children, InsertChildrenDto>();
            CreateMap<InsertChildrenDto, Children>();
            CreateMap<Children, UpdateChildrenDto>();
            CreateMap<UpdateChildrenDto, Children>();
        }
    }
}
