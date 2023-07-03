using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Map
{
    public class DependentMapProfile :Profile
    {
        public DependentMapProfile()
        {
            CreateMap<Dependent, ReadDependentDto>();
            CreateMap<ReadDependentDto, Dependent>();
            CreateMap<Dependent, InsertDependentDto>();
            CreateMap<InsertDependentDto, Dependent>();
            CreateMap<Dependent, UpdateDependentDto>();
            CreateMap<UpdateDependentDto, Dependent>();
        }
    }
}
