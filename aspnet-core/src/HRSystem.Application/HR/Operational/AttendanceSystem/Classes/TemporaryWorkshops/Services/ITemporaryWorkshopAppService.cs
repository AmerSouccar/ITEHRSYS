using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Services
{
    public interface ITemporaryWorkshopAppService :IApplicationService
    {
        public PagedResultDto<ReadTemporaryWorkshopDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadTemporaryWorkshopDto> GetbyId(Guid id);
        public Task<InsertTemporaryWorkshopDto> Insert(InsertTemporaryWorkshopDto temporaryWorkshop);
        public Task<UpdateTemporaryWorkshopDto> Update(UpdateTemporaryWorkshopDto temporaryWorkshop);
        public Task Delete(Guid id);
    }
}

