using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Banks.Map
{
    public class BankMapProfile : Profile
    {
        public BankMapProfile()
        {
            CreateMap<BankDto, Bank>();
            CreateMap<Bank, BankDto>();
            CreateMap<InsertBankDto, Bank>();
            CreateMap<Bank, InsertBankDto>();
            CreateMap<UpdateBankDto, Bank>();
            CreateMap<Bank, UpdateBankDto>();
            CreateMap<ReadBankDto, Bank>();
            CreateMap<Bank, ReadBankDto>();
        }
    }
}
