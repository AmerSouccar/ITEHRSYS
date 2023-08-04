using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Indexes.OrganizationLevels.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Services
{
    public class JobDescriptionAppService : HRSystemAppServiceBase, IJobDescriptionAppService
    {
        private readonly IJobDescriptionDomainService _jobDescriptionDomainService;

        public JobDescriptionAppService(IJobDescriptionDomainService jobDescriptionDomainService)
        {
            _jobDescriptionDomainService = jobDescriptionDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _jobDescriptionDomainService.Delete(id);
        }

        public PagedResultDto<ReadJobDescriptionDto>GetAll(PagedGeneralResultRequestDto input)
        {
            var jobDescriptions = _jobDescriptionDomainService.GetAll();
            int total = jobDescriptions.Count();
            jobDescriptions = jobDescriptions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadJobDescriptionDto>>(jobDescriptions.ToList());
            return new PagedResultDto<ReadJobDescriptionDto>(total, list);
        }

        public async Task<ReadJobDescriptionDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadJobDescriptionDto>(await _jobDescriptionDomainService.GetbyId(id));
        }

        public async Task<InsertJobDescriptionDto> Insert(InsertJobDescriptionDto jobDescription)
        {
            return ObjectMapper.Map<InsertJobDescriptionDto>(await _jobDescriptionDomainService.Insert(ObjectMapper.Map<JobDescription>(jobDescription)));
        }

        public async Task<UpdateJobDescriptionDto> Update(UpdateJobDescriptionDto jobDescription)
        {
            return ObjectMapper.Map<UpdateJobDescriptionDto>(await _jobDescriptionDomainService.Update(ObjectMapper.Map<JobDescription>(jobDescription)));

        }
    }
}
