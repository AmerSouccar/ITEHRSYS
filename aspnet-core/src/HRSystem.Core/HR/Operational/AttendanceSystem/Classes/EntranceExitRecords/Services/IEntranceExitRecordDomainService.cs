using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Services
{
    public interface IEntranceExitRecordDomainService :IDomainService
    {
        public IQueryable<EntranceExitRecord> GetAll();
        public Task<EntranceExitRecord> GetbyId(Guid id);
        public Task<EntranceExitRecord> Insert(EntranceExitRecord entranceExitRecord);
        public Task<EntranceExitRecord> Update(EntranceExitRecord entranceExitRecord);
        public Task Delete(Guid id);
        public void ImportDataFromExcel(IFormFile file);
    }
}
