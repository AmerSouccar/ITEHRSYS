using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Services
{
    public interface IWorkshopAppService : IApplicationService
    {
        public Task<List<ReadWorkshopDto>> GetAll();
        public Task<ReadWorkshopDto> GetbyId(Guid id);
        public Task<InsertWorkshopDto> Insert(InsertWorkshopDto workshop);
        public Task<UpdateWorkshopDto> Update(UpdateWorkshopDto workshop);
        public Task Delete(Guid id);
    }
}
