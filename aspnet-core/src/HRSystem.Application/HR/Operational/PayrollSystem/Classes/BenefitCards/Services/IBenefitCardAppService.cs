using Abp.Application.Services;
using HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Services
{
    public interface IBenefitCardAppService : IApplicationService
    {
        public Task<List<ReadBenefitCardDto>> GetAll();
        public Task<ReadBenefitCardDto> GetbyId(Guid id);
        public Task<InsertBenefitCardDto> Insert(InsertBenefitCardDto benefitCard);
        public Task<UpdateBenefitCardDto> Update(UpdateBenefitCardDto benefitCard);
        public Task Delete(Guid id);
    }
}
