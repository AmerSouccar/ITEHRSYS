using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using HRSystem.HR.Operational.AttendanceSystem.Classes.HourlyMissions;
using OfficeOpenXml.Export.HtmlExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.NormalShifts.Services
{
    public interface INormalShiftDomainService :IDomainService
    {
        public IQueryable<NormalShift> GetAll();
        public IQueryable<NormalShift> GetAllById(Guid id);
        public Task<NormalShift> GetbyId(Guid id);
        public Task<NormalShift> Insert(NormalShift normalShift);
        public Task<NormalShift> Update(NormalShift normalShift);
        public Task Delete(Guid id);
    }
}
