using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Services
{
    public class EducationGradeAppService : HRSystemAppServiceBase, IEducationGradeAppService
    {
        private readonly IEducationGradeDomainService _educationGrade;

        public EducationGradeAppService(IEducationGradeDomainService educationGrade)
        {
            _educationGrade = educationGrade;
        }

        public async Task Delete(Guid id)
        {
            await _educationGrade.Delete(id);
        }

        public async Task<List<ReadEducationDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadEducationDto>>(await _educationGrade.GetAll());
        }

        public async Task<ReadEducationDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadEducationDto>(await _educationGrade.GetbyId(id));
        }

        public async Task<InsertEducationDto> Insert(InsertEducationDto educationGrade)
        {
           return ObjectMapper.Map<InsertEducationDto>(await _educationGrade.Insert(ObjectMapper.Map<EducationGrade>(educationGrade)));
        }

        public async Task<UpdateEducationDto> Update(UpdateEducationDto educationGrade)
        {
            return ObjectMapper.Map<UpdateEducationDto>(await _educationGrade.Update(ObjectMapper.Map<EducationGrade>(educationGrade)));

        }
    }
}
