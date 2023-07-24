using Abp.Application.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.Months.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Services
{
    public interface IMonthAppService : IApplicationService
    {
        public Task<List<ReadMonthDto>> GetAll();
        public Task<ReadMonthDto> GetbyId(Guid id);
        public Task<InsertMonthDto> Insert(InsertMonthDto month);
        public Task<UpdateMonthDto> Update(UpdateMonthDto month);
        public Task Delete(Guid id);
    }
}
