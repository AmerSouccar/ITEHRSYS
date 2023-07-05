using Abp.Application.Services;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Services
{
    public interface IGradeAppService :IApplicationService
    {
        public Task<List<ReadGradeDto>> GetAll();
        public Task<ReadGradeDto> GetbyId(Guid id);
        public Task<InsertGradeDto> Insert(InsertGradeDto grade);
        public Task<UpdateGradeDto> Update(UpdateGradeDto grade);
        public Task Delete(Guid id);
    }
}
