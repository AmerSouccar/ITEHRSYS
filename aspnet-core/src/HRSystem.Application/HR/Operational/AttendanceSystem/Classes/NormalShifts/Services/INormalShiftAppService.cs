using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Services
{
    public interface INormalShiftAppService :IApplicationService
    {
        public PagedResultDto<ReadNormalShiftDto> GetAll(PagedGeneralResultRequestDto input);
        public PagedResultDto<ReadNormalShiftDto> GetAllById(Guid WorkshopId,PagedGeneralResultRequestDto input);
        public Task<ReadNormalShiftDto> GetbyId(Guid id);
        public Task<InsertNormalShiftDto> Insert(InsertNormalShiftDto normalShift);
        public Task<UpdateNormalShiftDto> Update(UpdateNormalShiftDto normalShift);
        public Task Delete(Guid id);
    }
}
