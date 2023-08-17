using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Promotions.Services
{
    public interface IPromotionAppService : IApplicationService
    {
        public PagedResultDto<ReadPromotionDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadPromotionDto> GetbyId(Guid id);
        public Task<InsertPromotionDto> Insert(InsertPromotionDto promotion);
        public Task<UpdatePromotionDto> Update(UpdatePromotionDto promotion);
        public Task Delete(Guid id);
    }
}
