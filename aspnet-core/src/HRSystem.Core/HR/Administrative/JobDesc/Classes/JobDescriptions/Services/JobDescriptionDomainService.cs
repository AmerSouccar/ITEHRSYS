using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Services
{
    public class JobDescriptionDomainService : IJobDescriptionDomainService
    {
        private readonly IRepository<JobDescription,Guid> _jobDescriptionRepository;

        public JobDescriptionDomainService(IRepository<JobDescription, Guid> jobDescriptionRepository)
        {
            _jobDescriptionRepository = jobDescriptionRepository;
        }

        public async Task Delete(Guid id)
        {
           await _jobDescriptionRepository.DeleteAsync(id);
        }

        public async Task<List<JobDescription>> GetAll()
        {
            return _jobDescriptionRepository.GetAllIncluding(x => x.JobTitle, x => x.Node).ToList();
        }

        public async Task<JobDescription> GetbyId(Guid id)
        {
            var jobDescription = await _jobDescriptionRepository.GetAsync(id);
            if(jobDescription != null)
            {
                await _jobDescriptionRepository.EnsurePropertyLoadedAsync(jobDescription,x => x.JobTitle);
                await _jobDescriptionRepository.EnsurePropertyLoadedAsync(jobDescription,x => x.Node);
            }
            return jobDescription;
        }

        public async Task<JobDescription> Insert(JobDescription jobDescription)
        {
            return await _jobDescriptionRepository.InsertAsync(jobDescription);
        }

        public async Task<JobDescription> Update(JobDescription jobDescription)
        {
            return await _jobDescriptionRepository.UpdateAsync(jobDescription);
        }
    }
}
