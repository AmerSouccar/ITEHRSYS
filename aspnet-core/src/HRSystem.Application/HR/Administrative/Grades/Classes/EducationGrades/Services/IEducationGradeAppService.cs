using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Services
{
    public interface IEducationGradeAppService :IApplicationService
    {
        public Task<List<ReadEducationDto>> GetAll();
        public Task<ReadEducationDto> GetbyId(Guid id);
        public Task<InsertEducationDto> Insert(InsertEducationDto educationGrade);
        public Task<UpdateEducationDto> Update(UpdateEducationDto educationGrade);
        public Task Delete(Guid id);
    }
}
