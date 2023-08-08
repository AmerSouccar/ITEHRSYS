using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.BankInformations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.BankInformations.Map
{
    public class BankInformationMapProfile : Profile
    {
        public BankInformationMapProfile()
        {
            CreateMap<BankInformation, ReadBankInformationDto>();
            CreateMap<ReadBankInformationDto, BankInformation>();
            CreateMap<BankInformation, InsertBankInformationDto>();
            CreateMap<InsertBankInformationDto, BankInformation>();
            CreateMap<BankInformation, UpdateBankInformationDto>();
            CreateMap<UpdateBankInformationDto, BankInformation>();
        }
    }
}
