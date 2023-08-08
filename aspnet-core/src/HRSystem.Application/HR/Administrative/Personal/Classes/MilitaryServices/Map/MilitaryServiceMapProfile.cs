using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Map
{
    public class MilitaryServiceMapProfile :Profile
    {
        public MilitaryServiceMapProfile()
        {
            CreateMap<MilitaryService, ReadMilitaryServiceDto>();
            CreateMap<ReadMilitaryServiceDto, MilitaryService>();
            CreateMap<MilitaryService, InsertMilitaryServiceDto>();
            CreateMap<InsertMilitaryServiceDto, MilitaryService>();
            CreateMap<MilitaryService, UpdateMilitaryServiceDto>();
            CreateMap<UpdateMilitaryServiceDto, MilitaryService>();
        }
    }
}
