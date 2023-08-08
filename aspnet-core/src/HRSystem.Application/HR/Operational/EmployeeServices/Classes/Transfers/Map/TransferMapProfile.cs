using AutoMapper;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Dto;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Map
{
    public class TransferMapProfile :Profile
    {
        public TransferMapProfile()
        {
            CreateMap<Transfer, ReadTransferDto>();
            CreateMap<ReadTransferDto, Transfer>();
            CreateMap<Transfer, InsertTransferDto>();
            CreateMap<InsertTransferDto, Transfer>();
            CreateMap<Transfer, UpdateTransferDto>();
            CreateMap<UpdateTransferDto, Transfer>();
        }
    }
}
