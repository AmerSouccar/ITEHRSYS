using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.ChangeableHolidays.Services
{
    public interface IChangeableHolidayAppService : IApplicationService
    {
        public PagedResultDto<ReadChangeableHolidayDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadChangeableHolidayDto> GetbyId(Guid id);
        public Task<InsertChangeableHolidayDto> Insert(InsertChangeableHolidayDto changeableHoliday);
        public Task<UpdateChangeableHolidayDto> Update(UpdateChangeableHolidayDto changeableHoliday);
        public Task Delete(Guid id);
    }
}
