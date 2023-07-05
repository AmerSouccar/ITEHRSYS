using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Services
{
    public class JobTitleAppService : HRSystemAppServiceBase, IJobTitleAppService
    {
        private readonly IJobTitleDomainService _jobTitleDomainService;

        public JobTitleAppService(IJobTitleDomainService jobTitleDomainService)
        {
            _jobTitleDomainService = jobTitleDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _jobTitleDomainService.Delete(id); 
        }

        public async Task<List<ReadJobTitleDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadJobTitleDto>>(await _jobTitleDomainService.GetAll());
        }

        public async Task<ReadJobTitleDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadJobTitleDto>(await _jobTitleDomainService.GetbyId(id));
        }

        public async Task<InsertJobTitleDto> Insert(InsertJobTitleDto jobTitle)
        {
            return ObjectMapper.Map<InsertJobTitleDto>(await _jobTitleDomainService.Insert(ObjectMapper.Map<JobTitle>(jobTitle)));
        }

        public async Task<UpdateJobTitleDto> Update(UpdateJobTitleDto jobTitle)
        {
            return ObjectMapper.Map<UpdateJobTitleDto>(await _jobTitleDomainService.Update(ObjectMapper.Map<JobTitle>(jobTitle)));

        }
    }
}
