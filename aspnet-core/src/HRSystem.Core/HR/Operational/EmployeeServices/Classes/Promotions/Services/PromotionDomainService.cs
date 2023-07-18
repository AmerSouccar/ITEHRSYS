using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.LeaveSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Services
{
    public class PromotionDomainService : IPromotionDomainService
    {
        private readonly IRepository<Promotion,Guid> _promotionRepository;

        public PromotionDomainService(IRepository<Promotion, Guid> promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }

        public async Task Delete(Guid id)
        {
            await _promotionRepository.DeleteAsync(id);
        }

        public async Task<List<Promotion>> GetAll()
        {
            return _promotionRepository.GetAllIncluding(x => x.JobTitle, x => x.Position, x => x.EmployeeCard).ToList();
        }

        public async Task<Promotion> GetbyId(Guid id)
        {
            Promotion promotion = await _promotionRepository.GetAsync(id);
            if (promotion != null)
            {
                await _promotionRepository.EnsurePropertyLoadedAsync(promotion, x => x.JobTitle);

                await _promotionRepository.EnsurePropertyLoadedAsync(promotion, x => x.Position);

                await _promotionRepository.EnsurePropertyLoadedAsync(promotion, x => x.EmployeeCard);
            }
            return promotion;
        }

        public async Task<Promotion> Insert(Promotion promotion)
        {
            return await _promotionRepository.InsertAsync(promotion);
        }

        public async Task<Promotion> Update(Promotion promotion)
        {
            return await _promotionRepository.UpdateAsync(promotion);

        }
    }
}
