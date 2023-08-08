using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Services
{
    public interface ITemporaryWorkshopAppService :IApplicationService
    {
        public Task<List<ReadTemporaryWorkshopDto>> GetAll();
        public Task<ReadTemporaryWorkshopDto> GetbyId(Guid id);
        public Task<InsertTemporaryWorkshopDto> Insert(InsertTemporaryWorkshopDto temporaryWorkshop);
        public Task<UpdateTemporaryWorkshopDto> Update(UpdateTemporaryWorkshopDto temporaryWorkshop);
        public Task Delete(Guid id);
    }
}

