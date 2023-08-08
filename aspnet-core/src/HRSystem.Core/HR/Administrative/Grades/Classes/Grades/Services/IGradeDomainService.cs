using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Services
{
    public interface IGradeDomainService : IDomainService
    {
        public IQueryable<Grade> GetAll();
        public Task<Grade> GetbyId(Guid id);
        public Task<Grade> Insert(Grade grade);
        public Task<Grade> Update(Grade grade);
        public Task Delete(Guid id);
    }
}
