using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceMonthlyCards;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.PaginationDto;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Services
{
    public class EntranceExitRecordAppService : HRSystemAppServiceBase, IEntranceExitRecordAppService
    {
        private readonly IEntranceExitRecordDomainService _entranceExitRecord;

        public EntranceExitRecordAppService(IEntranceExitRecordDomainService entranceExitRecord)
        {
            _entranceExitRecord = entranceExitRecord;
        }

        public async Task Delete(Guid id)
        {
            await _entranceExitRecord.Delete(id);
        }

        public PagedResultDto<ReadEntranceExitRecordDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var entranceExitRecords = _entranceExitRecord.GetAll();
            int total = entranceExitRecords.Count();
            entranceExitRecords = entranceExitRecords.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadEntranceExitRecordDto>>(entranceExitRecords.ToList());
            return new PagedResultDto<ReadEntranceExitRecordDto>(total, list);
        }

        public async Task<ReadEntranceExitRecordDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadEntranceExitRecordDto>(await _entranceExitRecord.GetbyId(id));
        }

        public void ImportDataFromExcel(IFormFile file)
        {
            _entranceExitRecord?.ImportDataFromExcel(file);
        }

        public async Task<InsertEntranceExitRecordDto> Insert(InsertEntranceExitRecordDto entranceExitRecord)
        {
            return ObjectMapper.Map<InsertEntranceExitRecordDto>(await _entranceExitRecord.Insert(ObjectMapper.Map<EntranceExitRecord>(entranceExitRecord)));
        }

        public async Task<UpdateEntranceExitRecordDto> Update(UpdateEntranceExitRecordDto entranceExitRecord)
        {
            return ObjectMapper.Map<UpdateEntranceExitRecordDto>(await _entranceExitRecord.Update(ObjectMapper.Map<EntranceExitRecord>(entranceExitRecord)));

        }
    }
}
