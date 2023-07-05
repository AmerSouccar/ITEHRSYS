using Abp.Application.Services;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Services
{
    public interface IJobDescriptionAppService :IApplicationService
    {
        public Task<List<ReadJobDescriptionDto>> GetAll();
        public Task<ReadJobDescriptionDto> GetbyId(Guid id);
        public Task<InsertJobDescriptionDto> Insert(InsertJobDescriptionDto jobDescription);
        public Task<UpdateJobDescriptionDto> Update(UpdateJobDescriptionDto jobDescription);
        public Task Delete(Guid id);
    }
}
