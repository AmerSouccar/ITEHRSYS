using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Services
{
    public class JobTitleDomainService : IJobTitleDomainService
    {
        private readonly IRepository<JobTitle,Guid> _jobTitleRepository;

        public JobTitleDomainService(IRepository<JobTitle, Guid> jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }

        public async Task Delete(Guid id)
        {
           await _jobTitleRepository.DeleteAsync(id);
        }

        public IQueryable<JobTitle> GetAll()
        {
            return  _jobTitleRepository.GetAll();
        }

        public async Task<JobTitle> GetbyId(Guid id)
        {
            return await _jobTitleRepository.GetAsync(id);
        }

        public async Task<JobTitle> Insert(JobTitle jobTitle)
        {
            return await _jobTitleRepository.InsertAsync(jobTitle);
        }

        public async Task<JobTitle> Update(JobTitle jobTitle)
        {
            return await _jobTitleRepository.UpdateAsync(jobTitle);
        }
    }
}
