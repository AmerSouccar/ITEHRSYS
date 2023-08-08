using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<ReadEntranceExitRecordDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadEntranceExitRecordDto>>(await _entranceExitRecord.GetAll());
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
