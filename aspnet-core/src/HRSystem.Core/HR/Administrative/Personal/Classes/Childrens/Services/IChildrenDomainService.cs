using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Services
{
    public  interface IChildrenDomainService :IDomainService
    {
        public IQueryable<Children> GetAll();
        public Task<Children> GetbyId(Guid id);
        public Task<Children> Insert(Children children);
        public Task<Children> Update(Children children);
        public Task Delete(Guid id);
    }
}
