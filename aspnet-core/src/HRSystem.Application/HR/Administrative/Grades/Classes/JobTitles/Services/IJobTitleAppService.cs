using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.JobTitles.Services
{
    public interface IJobTitleAppService : IApplicationService
    {
        public PagedResultDto<ReadJobTitleDto>GetAll(PagedGeneralResultRequestDto input);
        public PagedResultDto<ReadJobTitleDto>GetAllbyId(Guid id, PagedGeneralResultRequestDto input);
        public Task<ReadJobTitleDto> GetbyId(Guid id);
        public Task<UpdateJobTitleDto> GetForEdit(Guid id);
        public Task<InsertJobTitleDto> Insert(InsertJobTitleDto jobTitle);
        public Task<UpdateJobTitleDto> Update(UpdateJobTitleDto jobTitle);
        public Task Delete(Guid id);
    }
}
