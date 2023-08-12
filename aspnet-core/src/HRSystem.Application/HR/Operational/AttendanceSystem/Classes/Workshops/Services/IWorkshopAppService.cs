using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Services
{
    public interface IWorkshopAppService : IApplicationService
    {
        public PagedResultDto<ReadWorkshopDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadWorkshopDto> GetbyId(Guid id);
        public Task<UpdateWorkshopDto> GetForEdit(Guid id);
        public Task<InsertWorkshopDto> Insert(InsertWorkshopDto workshop);
        public Task<UpdateWorkshopDto> Update(UpdateWorkshopDto workshop);
        public Task Delete(Guid id);
    }
}
