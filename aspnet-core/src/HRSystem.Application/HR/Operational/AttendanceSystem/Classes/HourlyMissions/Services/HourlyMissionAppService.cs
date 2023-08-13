using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.PaginationDto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions.Services
{
    public class HourlyMissionAppService : HRSystemAppServiceBase, IHourlyMissionAppService
    {
        private readonly IHourlyMissionDomainService _hourlyMissionDomainService;

        public HourlyMissionAppService(IHourlyMissionDomainService hourlyMissionDomainService)
        {
            _hourlyMissionDomainService = hourlyMissionDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _hourlyMissionDomainService.Delete(id);
        }

        public PagedResultDto<ReadHourlyMissionDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var hourlyMissions = _hourlyMissionDomainService.GetAll();
            int total = hourlyMissions.Count();
            hourlyMissions = hourlyMissions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadHourlyMissionDto>>(hourlyMissions.ToList());
            return new PagedResultDto<ReadHourlyMissionDto>(total, list);
        }

        public async Task<ReadHourlyMissionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadHourlyMissionDto>(await _hourlyMissionDomainService.GetbyId(id));
        }

        public async Task<InsertHourlyMissionDto> Insert(InsertHourlyMissionDto hourlyMission)
        {
            return ObjectMapper.Map<InsertHourlyMissionDto>(await _hourlyMissionDomainService.Insert(ObjectMapper.Map<HourlyMission>(hourlyMission)));
        }

        public async Task<UpdateHourlyMissionDto> Update(UpdateHourlyMissionDto hourlyMission)
        {
            return ObjectMapper.Map<UpdateHourlyMissionDto>(await _hourlyMissionDomainService.Update(ObjectMapper.Map<HourlyMission>(hourlyMission)));

        }
    }
}
