using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Map
{
    public class ResignationMapProfile :Profile
    {
        public ResignationMapProfile()
        {
            CreateMap<Resignation, ReadResignationDto>();
            CreateMap<ReadResignationDto, Resignation>();
            CreateMap<Resignation, InsertResignationDto>();
            CreateMap<InsertResignationDto, Resignation>();
            CreateMap<Resignation, UpdateResignationDto>();
            CreateMap<UpdateResignationDto, Resignation>();
        }
    }
}
