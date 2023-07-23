using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Services
{
    public class PromotionAppService : HRSystemAppServiceBase, IPromotionAppService
    {
        private readonly IPromotionDomainService _promotionDomainService;

        public PromotionAppService(IPromotionDomainService promotionDomainService)
        {
            _promotionDomainService = promotionDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _promotionDomainService.Delete(id);
        }

        public async Task<List<ReadPromotionDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadPromotionDto>>(await _promotionDomainService.GetAll());
        }

        public async Task<ReadPromotionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadPromotionDto>(await _promotionDomainService.GetbyId(id));
        }

        public async Task<InsertPromotionDto> Insert(InsertPromotionDto promotion)
        {
            return ObjectMapper.Map<InsertPromotionDto>(await _promotionDomainService.Insert(ObjectMapper.Map<Promotion>(promotion)));
        }

        public async Task<UpdatePromotionDto> Update(UpdatePromotionDto promotion)
        {
            return ObjectMapper.Map<UpdatePromotionDto>(await _promotionDomainService.Update(ObjectMapper.Map<Promotion>(promotion)));

        }
    }
}
