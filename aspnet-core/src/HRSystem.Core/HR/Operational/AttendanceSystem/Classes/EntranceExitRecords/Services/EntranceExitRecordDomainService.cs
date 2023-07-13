using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Services
{
    public class EntranceExitRecordDomainService : IEntranceExitRecordDomainService
    {
        private readonly IRepository<EntranceExitRecord,Guid> _entranceExitRecordRepository;

        public EntranceExitRecordDomainService(IRepository<EntranceExitRecord, Guid> entranceExitRecordRepository)
        {
            _entranceExitRecordRepository = entranceExitRecordRepository;
        }

        public async Task Delete(Guid id)
        {
            await _entranceExitRecordRepository.DeleteAsync(id);
        }

        public async Task<List<EntranceExitRecord>> GetAll()
        {
            return _entranceExitRecordRepository.GetAllIncluding(x =>x.Employee).ToList();
        }

        public async Task<EntranceExitRecord> GetbyId(Guid id)
        {
            EntranceExitRecord entranceExitRecord = await _entranceExitRecordRepository.GetAsync(id);
            if (entranceExitRecord != null)
            {
                await _entranceExitRecordRepository.EnsurePropertyLoadedAsync(entranceExitRecord, x => x.Employee);
            }
            return entranceExitRecord;
        }

        public async Task<EntranceExitRecord> Insert(EntranceExitRecord entranceExitRecord)
        {
            return await _entranceExitRecordRepository.InsertAsync(entranceExitRecord);
        }

        public async Task<EntranceExitRecord> Update(EntranceExitRecord entranceExitRecord)
        {
            return await _entranceExitRecordRepository.UpdateAsync(entranceExitRecord);

        }
    }
}
