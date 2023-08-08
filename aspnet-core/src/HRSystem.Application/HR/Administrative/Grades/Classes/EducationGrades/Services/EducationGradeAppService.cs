using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadEducationGradeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var educationGrade = _educationGrade.GetAll();
            int total = educationGrade.Count();
            educationGrade = educationGrade.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadEducationGradeDto>>(educationGrade.ToList());
            return new PagedResultDto<ReadEducationGradeDto>(total, list);
        }

        public async Task<ReadEducationGradeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadEducationGradeDto>(await _educationGrade.GetbyId(id));
        }

        public async Task<InsertEducationGradeDto> Insert(InsertEducationGradeDto educationGrade)
        {
           return ObjectMapper.Map<InsertEducationGradeDto>(await _educationGrade.Insert(ObjectMapper.Map<EducationGrade>(educationGrade)));
        }

        public async Task<UpdateEducationGradeDto> Update(UpdateEducationGradeDto educationGrade)
        {
            return ObjectMapper.Map<UpdateEducationGradeDto>(await _educationGrade.Update(ObjectMapper.Map<EducationGrade>(educationGrade)));

        }
    }
}
