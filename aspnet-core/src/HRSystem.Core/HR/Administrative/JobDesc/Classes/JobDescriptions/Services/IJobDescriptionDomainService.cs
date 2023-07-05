using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Services
{
    public interface IJobDescriptionDomainService : IDomainService
    {
        public Task<List<JobDescription>> GetAll();
        public Task<JobDescription> GetbyId(Guid id);
        public Task<JobDescription> Insert(JobDescription jobDescription);
        public Task<JobDescription> Update(JobDescription jobDescription);
        public Task Delete(Guid id);
    }
}
