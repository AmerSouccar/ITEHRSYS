using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.FixedHolidays.Services
{
    public interface IFixedHolidayAppService :IApplicationService
    {
        public PagedResultDto<ReadFixedHolidayDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadFixedHolidayDto> GetbyId(Guid id);
        public Task<UpdateFixedHolidayDto> GetForEdit(Guid id);
        public Task<InsertFixedHolidayDto> Insert(InsertFixedHolidayDto fixedHoliday);
        public Task<UpdateFixedHolidayDto> Update(UpdateFixedHolidayDto fixedHoliday);
        public Task Delete(Guid id);
    }
}
