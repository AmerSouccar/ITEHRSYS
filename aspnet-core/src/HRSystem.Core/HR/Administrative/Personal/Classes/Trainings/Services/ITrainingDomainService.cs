using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Spouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Services
{
    public interface ITrainingDomainService :IDomainService
    {
        public IQueryable<Training> GetAll();
        public Task<Training> GetbyId(Guid id);
        public Task<Training> Insert(Training training);
        public Task<Training> Update(Training training);
        public Task Delete(Guid id);
    }
}
