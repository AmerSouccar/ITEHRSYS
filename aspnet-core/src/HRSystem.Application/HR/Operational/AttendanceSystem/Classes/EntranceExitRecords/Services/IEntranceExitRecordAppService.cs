using Abp.Application.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Services
{
    public interface IEntranceExitRecordAppService : IApplicationService
    {
        public Task<List<ReadEntranceExitRecordDto>> GetAll();
        public Task<ReadEntranceExitRecordDto> GetbyId(Guid id);
        public Task<InsertEntranceExitRecordDto> Insert(InsertEntranceExitRecordDto entranceExitRecord);
        public Task<UpdateEntranceExitRecordDto> Update(UpdateEntranceExitRecordDto entranceExitRecord);
        public Task Delete(Guid id);
        public void ImportDataFromExcel(IFormFile file);
    }
}
