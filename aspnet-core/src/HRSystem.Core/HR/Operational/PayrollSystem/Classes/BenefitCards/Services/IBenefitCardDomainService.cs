using Abp.Domain.Services;
using HRSystem.HR.Operational.EmployeeServices.Classes.Transfers;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.PayrollSystem.Classes.BenefitCards.Services
{
    public interface IBenefitCardDomainService :IDomainService
    {
        public Task<List<BenefitCard>> GetAll();
        public Task<BenefitCard> GetbyId(Guid id);
        public Task<BenefitCard> Insert(BenefitCard benefitCard);
        public Task<BenefitCard> Update(BenefitCard benefitCard);
        public Task Delete(Guid id);
    }
}
