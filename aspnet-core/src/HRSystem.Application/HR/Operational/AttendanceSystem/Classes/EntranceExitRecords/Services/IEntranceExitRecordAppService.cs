using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Dto;
using HRSystem.HR.PaginationDto;
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
        public PagedResultDto<ReadEntranceExitRecordDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadEntranceExitRecordDto> GetbyId(Guid id);
        public Task<UpdateEntranceExitRecordDto> GetForEdit(Guid id);
        public Task<InsertEntranceExitRecordDto> Insert(InsertEntranceExitRecordDto entranceExitRecord);
        public Task<UpdateEntranceExitRecordDto> Update(UpdateEntranceExitRecordDto entranceExitRecord);
        public Task Delete(Guid id);
        public void ImportDataFromExcel(IFormFile file);
    }
}
