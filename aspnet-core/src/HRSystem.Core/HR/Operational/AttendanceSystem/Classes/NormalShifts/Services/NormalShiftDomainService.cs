﻿using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public  IQueryable<NormalShift> GetAll()
        {
            return _normalShiftRepository.GetAll();
        }

        public IQueryable<NormalShift> GetAllById(Guid id)
        {
            return _normalShiftRepository.GetAll().Where(x => x.WorkshopId == id);
        }

        public async Task<NormalShift> GetbyId(Guid id)
        {
            NormalShift normalShift = await _normalShiftRepository.GetAsync(id);
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
