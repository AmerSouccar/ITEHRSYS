using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Services
{
    public interface IMilitaryServiceDomainService :IDomainService
    {
        public IQueryable<MilitaryService> GetAll();
        public Task<MilitaryService> GetbyId(Guid id);
        public Task<MilitaryService> Insert(MilitaryService militaryService);
        public Task<MilitaryService> Update(MilitaryService militaryService);
        public Task Delete(Guid id);
    }
}
