using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Childrens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Services
{
    public interface IConvictionDomainService :IDomainService
    {
        public Task<List<Conviction>> GetAll();
        public Task<Conviction> GetbyId(Guid id);
        public Task<Conviction> Insert(Conviction conviction);
        public Task<Conviction> Update(Conviction conviction);
        public Task Delete(Guid id);
    }
}
