using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Services
{
    public class TemporaryWorkshopAppService : HRSystemAppServiceBase, ITemporaryWorkshopAppService
    {
        private readonly ITemporaryWorkshopDomainService _temporaryWorkshopdomainService;

        public TemporaryWorkshopAppService(ITemporaryWorkshopDomainService temporaryWorkshopdomainService)
        {
            _temporaryWorkshopdomainService = temporaryWorkshopdomainService;
        }

        public async Task Delete(Guid id)
        {
            await _temporaryWorkshopdomainService.Delete(id);
        }

        public async Task<List<ReadTemporaryWorkshopDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadTemporaryWorkshopDto>>(await _temporaryWorkshopdomainService.GetAll());
        }

        public async Task<ReadTemporaryWorkshopDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadTemporaryWorkshopDto>(await _temporaryWorkshopdomainService.GetbyId(id));
        }

        public async Task<InsertTemporaryWorkshopDto> Insert(InsertTemporaryWorkshopDto temporaryWorkshop)
        {
            return ObjectMapper.Map<InsertTemporaryWorkshopDto>(await _temporaryWorkshopdomainService.Insert(ObjectMapper.Map<TemporaryWorkshop>(temporaryWorkshop)));
        }

        public async Task<UpdateTemporaryWorkshopDto> Update(UpdateTemporaryWorkshopDto temporaryWorkshop)
        {
            return ObjectMapper.Map<UpdateTemporaryWorkshopDto>(await _temporaryWorkshopdomainService.Update(ObjectMapper.Map<TemporaryWorkshop>(temporaryWorkshop)));

        }
    }
}
