using Abp.Application.Services;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto;
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
        public Task<List<ReadEducationGradeDto>> GetAll();
        public Task<ReadEducationGradeDto> GetbyId(Guid id);
        public Task<InsertEducationGradeDto> Insert(InsertEducationGradeDto educationGrade);
        public Task<UpdateEducationGradeDto> Update(UpdateEducationGradeDto educationGrade);
        public Task Delete(Guid id);
    }
}
