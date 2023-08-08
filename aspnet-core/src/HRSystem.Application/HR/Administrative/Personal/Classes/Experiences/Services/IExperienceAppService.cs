using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Experiences.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Experiences.Services
{
    public interface IExperienceAppService :IApplicationService
    {
        public PagedResultDto<ReadExperienceDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadExperienceDto> GetbyId(Guid id);
        public Task<InsertExperienceDto> Insert(InsertExperienceDto experience);
        public Task<UpdateExperienceDto> Update(UpdateExperienceDto experience);
        public Task Delete(Guid id);
    }
}
