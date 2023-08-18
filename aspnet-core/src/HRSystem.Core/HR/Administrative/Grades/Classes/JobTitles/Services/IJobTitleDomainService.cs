using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Services
{
    public interface IJobTitleDomainService : IDomainService
    {
        public IQueryable<JobTitle>GetAll();
        public IQueryable<JobTitle>GetAllbyId(Guid id);
        public Task<JobTitle> GetbyId(Guid id);
        public Task<JobTitle> Insert(JobTitle jobTitle);
        public Task<JobTitle> Update(JobTitle jobTitle);
        public Task Delete(Guid id);
    }
}
