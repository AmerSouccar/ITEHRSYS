using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Services
{
    public class EducationGradeDomainService : IEducationGradeDomainService
    {
        private readonly IRepository<EducationGrade, Guid> _educationGradeRepository;

        public EducationGradeDomainService(IRepository<EducationGrade, Guid> educationGradeRepository)
        {
            _educationGradeRepository = educationGradeRepository;
        }

        public async Task Delete(Guid id)
        {
            await _educationGradeRepository.DeleteAsync(id);
        }

        public IQueryable<EducationGrade> GetAll()
        {
            return  _educationGradeRepository.GetAll();
        }

        public async Task<EducationGrade> GetbyId(Guid id)
        {
            return await _educationGradeRepository.GetAsync(id);
        }

        public async Task<EducationGrade> Insert(EducationGrade educationGrade)
        {
            return await _educationGradeRepository.InsertAsync(educationGrade);
        }

        public async Task<EducationGrade> Update(EducationGrade educationGrade)
        {
            return await _educationGradeRepository.UpdateAsync(educationGrade);
        }
    }
}
