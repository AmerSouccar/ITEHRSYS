using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Services
{
    public interface IGradeAppService :IApplicationService
    {
        public PagedResultDto<ReadGradeDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadGradeDto> GetbyId(Guid id);
        public Task<InsertGradeDto> Insert(InsertGradeDto grade);
        public Task<UpdateGradeDto> Update(UpdateGradeDto grade);
        public Task Delete(Guid id);
    }
}
