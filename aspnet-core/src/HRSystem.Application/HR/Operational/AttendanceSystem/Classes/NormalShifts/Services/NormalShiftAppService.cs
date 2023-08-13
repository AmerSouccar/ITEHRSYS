using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceForms;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Services
{
    public class NormalShiftAppService : HRSystemAppServiceBase, INormalShiftAppService
    {
        private readonly INormalShiftDomainService _normalShiftdomainService;

        public NormalShiftAppService(INormalShiftDomainService normalShiftdomainService)
        {
            _normalShiftdomainService = normalShiftdomainService;
        }

        public async Task Delete(Guid id)
        {
            await _normalShiftdomainService.Delete(id);
        }

        public PagedResultDto<ReadNormalShiftDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var normalshifts = _normalShiftdomainService.GetAll();
            int total = normalshifts.Count();
            normalshifts = normalshifts.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadNormalShiftDto>>(normalshifts.ToList());
            return new PagedResultDto<ReadNormalShiftDto>(total, list);
        }

        public PagedResultDto<ReadNormalShiftDto> GetAllById(Guid WorkshopId, PagedGeneralResultRequestDto input)
        {
            var workshops = _normalShiftdomainService.GetAllById(WorkshopId);
            int total = workshops.Count();
            workshops = workshops.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadNormalShiftDto>>(workshops.ToList());
            return new PagedResultDto<ReadNormalShiftDto>(total, list);
        }

        public async Task<ReadNormalShiftDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadNormalShiftDto>(await _normalShiftdomainService.GetbyId(id));
        }

        public async Task<InsertNormalShiftDto> Insert(InsertNormalShiftDto normalShift)
        {
           return ObjectMapper.Map<InsertNormalShiftDto>(await _normalShiftdomainService.Insert(ObjectMapper.Map<NormalShift>(normalShift)));
        }

        public async Task<UpdateNormalShiftDto> Update(UpdateNormalShiftDto normalShift)
        {
            return ObjectMapper.Map<UpdateNormalShiftDto>(await _normalShiftdomainService.Update(ObjectMapper.Map<NormalShift>(normalShift)));

        }
    }
}
