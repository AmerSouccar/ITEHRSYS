using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.PaginationDto;

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

        public PagedResultDto<ReadWorkshopDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var workshops = _workshopDomainService.GetAll();
            int total = workshops.Count();
            workshops = workshops.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadWorkshopDto>>(workshops.ToList());
            return new PagedResultDto<ReadWorkshopDto>(total, list);
        }

        public PagedResultDto<ReadWorkshopDto> GetAllById(Guid attendanceFormId, PagedGeneralResultRequestDto input)
        {
            var workshops = _workshopDomainService.GetAllById(attendanceFormId);
            int total = workshops.Count();
            workshops = workshops.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadWorkshopDto>>(workshops.ToList());
            return new PagedResultDto<ReadWorkshopDto>(total, list);
        }

        public async Task<ReadWorkshopDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadWorkshopDto>(await _workshopDomainService.GetbyId(id));
        }

        public async Task<UpdateWorkshopDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdateWorkshopDto>(await _workshopDomainService.GetbyId(id));
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
