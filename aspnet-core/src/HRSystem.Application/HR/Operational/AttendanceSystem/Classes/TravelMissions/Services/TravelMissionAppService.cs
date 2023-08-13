using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TemporaryWorkshops.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.TravelMissions.Services
{
    public class TravelMissionAppService : HRSystemAppServiceBase, ITravelMissionAppService
    {
        private readonly ITravelMissionDomainService _travelMissiondomainService;

        public TravelMissionAppService(ITravelMissionDomainService travelMissiondomainService)
        {
            _travelMissiondomainService = travelMissiondomainService;
        }

        public async Task Delete(Guid id)
        {
            await _travelMissiondomainService.Delete(id);
        }

        public PagedResultDto<ReadTravelMissionDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var travelMissions = _travelMissiondomainService.GetAll();
            int total = travelMissions.Count();
            travelMissions = travelMissions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadTravelMissionDto>>(travelMissions.ToList());
            return new PagedResultDto<ReadTravelMissionDto>(total, list);
        }

        public async Task<ReadTravelMissionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadTravelMissionDto>(await _travelMissiondomainService.GetbyId(id));
        }

        public async Task<InsertTravelMissionDto> Insert(InsertTravelMissionDto travelMission)
        {
            return ObjectMapper.Map<InsertTravelMissionDto>(await _travelMissiondomainService.Insert(ObjectMapper.Map<TravelMission>(travelMission)));
        }

        public async Task<UpdateTravelMissionDto> Update(UpdateTravelMissionDto travelMission)
        {
            return ObjectMapper.Map<UpdateTravelMissionDto>(await _travelMissiondomainService.Update(ObjectMapper.Map<TravelMission>(travelMission)));

        }
    }
}
