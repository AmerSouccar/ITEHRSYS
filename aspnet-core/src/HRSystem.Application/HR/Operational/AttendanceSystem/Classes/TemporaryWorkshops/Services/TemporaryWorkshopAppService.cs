using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.Workshops;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadTemporaryWorkshopDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var temporaryWorkshops = _temporaryWorkshopdomainService.GetAll();
            int total = temporaryWorkshops.Count();
            temporaryWorkshops = temporaryWorkshops.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadTemporaryWorkshopDto>>(temporaryWorkshops.ToList());
            return new PagedResultDto<ReadTemporaryWorkshopDto>(total, list);
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
