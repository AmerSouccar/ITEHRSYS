using Abp.Domain.Repositories;
using HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.Months.Services
{
    public class MonthDomainService : IMonthDomainService
    {
        private readonly IRepository<Month,Guid> _monthRepository;

        public MonthDomainService(IRepository<Month, Guid> monthRepository)
        {
            _monthRepository = monthRepository;
        }

        public async Task Delete(Guid id)
        {
           await _monthRepository.DeleteAsync(id);
        }

        public async Task<List<Month>> GetAll()
        {
            return _monthRepository.GetAllIncluding(x => x.MonthlyCards).ToList();
        }

        public async Task<Month> GetbyId(Guid id)
        {
            Month month = await _monthRepository.GetAsync(id);
            if (month != null)
            {
                await _monthRepository.EnsureCollectionLoadedAsync(month, x => x.MonthlyCards);


            }
            return month;
        }

        public async Task<Month> Insert(Month month)
        {
            return await _monthRepository.InsertAsync(month);
        }

        public async Task<Month> Update(Month month)
        {
            return await _monthRepository.UpdateAsync(month);

        }
    }
}
