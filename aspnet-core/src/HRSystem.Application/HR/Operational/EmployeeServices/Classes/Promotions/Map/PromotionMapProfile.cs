using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Map
{
    public class PromotionMapProfile :Profile
    {
        public PromotionMapProfile()
        {
            CreateMap<Promotion, ReadPromotionDto>();
            CreateMap<ReadPromotionDto, Promotion>();
            CreateMap<Promotion, InsertPromotionDto>();
            CreateMap<InsertPromotionDto, Promotion>();
            CreateMap<Promotion, UpdatePromotionDto>();
            CreateMap<UpdatePromotionDto, Promotion>();
        }
    }
}
