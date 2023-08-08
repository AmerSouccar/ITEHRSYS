using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Services
{
    public class WorkshopAppService : HRSystemAppServiceBase, IWorkshopAppService
    {
        private readonly IWorkshopDomainService _workshopDomainService;

        public WorkshopAppService(IWorkshopDomainService workshopDomainService)
        {
            _workshopDomainService = workshopDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _workshopDomainService.Delete(id);
        }

        public async Task<List<ReadWorkshopDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadWorkshopDto>>(await _workshopDomainService.GetAll());
        }

        public async Task<ReadWorkshopDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadWorkshopDto>(await _workshopDomainService.GetbyId(id));
        }

        public async Task<InsertWorkshopDto> Insert(InsertWorkshopDto workshop)
        {
           return ObjectMapper.Map<InsertWorkshopDto>(await _workshopDomainService.Insert(ObjectMapper.Map<Workshop>(workshop)));
        }

        public async Task<UpdateWorkshopDto> Update(UpdateWorkshopDto workshop)
        {
            return ObjectMapper.Map<UpdateWorkshopDto>(await _workshopDomainService.Update(ObjectMapper.Map<Workshop>(workshop)));

        }
    }
}
