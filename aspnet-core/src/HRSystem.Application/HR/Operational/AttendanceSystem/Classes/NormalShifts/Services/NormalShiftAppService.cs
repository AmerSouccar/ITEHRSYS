using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
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

        public async Task<List<ReadNormalShiftDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadNormalShiftDto>>(await _normalShiftdomainService.GetAll());
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
