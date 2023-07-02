using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Skills.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Skills.Map
{
    public class SkillMapProfile :Profile
    {
        public SkillMapProfile()
        {
            CreateMap<Skill, ReadSkillDto>();
            CreateMap<ReadSkillDto, Skill>();
            CreateMap<Skill, InsertSkillDto>();
            CreateMap<InsertSkillDto, Skill>();
            CreateMap<Skill, UpdateSkillDto>();
            CreateMap<UpdateSkillDto, Skill>();
        }
    }
}
