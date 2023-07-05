using Abp.Application.Services;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Services
{
    public interface IJobTitleAppService : IApplicationService
    {
        public Task<List<ReadJobTitleDto>> GetAll();
        public Task<ReadJobTitleDto> GetbyId(Guid id);
        public Task<InsertJobTitleDto> Insert(InsertJobTitleDto jobTitle);
        public Task<UpdateJobTitleDto> Update(UpdateJobTitleDto jobTitle);
        public Task Delete(Guid id);
    }
}
