using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.MonthlyCards.Services
{
    public class MonthlyCardDominService : IMonthlyCardDominService
    {
        private readonly IRepository<MonthlyCard,Guid> _monthlyCardDominRepository;

        public MonthlyCardDominService(IRepository<MonthlyCard, Guid> monthlyCardDominRepository)
        {
            _monthlyCardDominRepository = monthlyCardDominRepository;
        }

        public async Task Delete(Guid id)
        {
            await _monthlyCardDominRepository.DeleteAsync(id);
        }

        public IQueryable<MonthlyCard> GetAll()
        {
            return _monthlyCardDominRepository.GetAllIncluding(x => x.EmployeeCard, x => x.BenefitCards, x => x.DeductionCards);
        }

        public IQueryable<MonthlyCard> GetAllbyId(Guid id)
        {
            return _monthlyCardDominRepository.GetAllIncluding(x => x.EmployeeCard.Employee).Where(x => x.MonthId == id);
        }

        public async Task<MonthlyCard> GetbyId(Guid id)
        {
            MonthlyCard monthlyCard = await _monthlyCardDominRepository.GetAsync(id);
            if (monthlyCard != null)
            {
                await _monthlyCardDominRepository.EnsurePropertyLoadedAsync(monthlyCard, x => x.EmployeeCard);
                await _monthlyCardDominRepository.EnsureCollectionLoadedAsync(monthlyCard, x => x.BenefitCards);
                await _monthlyCardDominRepository.EnsureCollectionLoadedAsync(monthlyCard, x => x.DeductionCards);


            }
            return monthlyCard;
        }

        public async Task<MonthlyCard> Insert(MonthlyCard monthlyCard)
        {
            return await _monthlyCardDominRepository.InsertAsync(monthlyCard);
        }

        public async Task<MonthlyCard> Update(MonthlyCard monthlyCard)
        {
            return await _monthlyCardDominRepository.UpdateAsync(monthlyCard);

        }
    }
}
