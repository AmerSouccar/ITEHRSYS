using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Classes.Trainings.Dto;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Map
{
    public class TrainingMapProfile :Profile
    {
        public TrainingMapProfile()
        {
            CreateMap<Training, ReadTrainingDto>();
            CreateMap<ReadTrainingDto, Training>();
            CreateMap<Training, InsertTrainingDto>();
            CreateMap<InsertTrainingDto, Training>();
            CreateMap<Training, UpdateTrainingDto>();
            CreateMap<UpdateTrainingDto, Training>();
        }
    }
}
