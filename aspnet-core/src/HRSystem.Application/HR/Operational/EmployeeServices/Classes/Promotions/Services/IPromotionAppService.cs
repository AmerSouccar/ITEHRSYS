using Abp.Application.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Services
{
    public interface IPromotionAppService : IApplicationService
    {
        public Task<List<ReadPromotionDto>> GetAll();
        public Task<ReadPromotionDto> GetbyId(Guid id);
        public Task<InsertPromotionDto> Insert(InsertPromotionDto promotion);
        public Task<UpdatePromotionDto> Update(UpdatePromotionDto promotion);
        public Task Delete(Guid id);
    }
}
