using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Services
{
    public class NormalShiftDomainService : INormalShiftDomainService
    {
        private readonly IRepository<NormalShift,Guid> _normalShiftRepository;

        public NormalShiftDomainService(IRepository<NormalShift, Guid> normalShiftRepository)
        {
            _normalShiftRepository = normalShiftRepository;
        }

        public async Task Delete(Guid id)
        {
            await _normalShiftRepository.DeleteAsync(id);
        }

        public async Task<List<NormalShift>> GetAll()
        {
            return await  _normalShiftRepository.GetAllListAsync();
        }

        public async Task<NormalShift> GetbyId(Guid id)
        {
            NormalShift normalShift = await _normalShiftRepository.GetAsync(id);
            if (normalShift != null)
            { 
                await _normalShiftRepository.EnsurePropertyLoadedAsync(normalShift);
            }
            return normalShift;

        }

        public async Task<NormalShift> Insert(NormalShift normalShift)
        {
            return await _normalShiftRepository.InsertAsync(normalShift);
        }

        public async Task<NormalShift> Update(NormalShift normalShift)
        {
            return await _normalShiftRepository.UpdateAsync(normalShift);

        }
    }
}
