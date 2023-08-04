using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Services
{
    public class GradeDomainService : IGradeDomainService
    {
        private readonly IRepository<Grade,Guid> _gradesRepository;

        public GradeDomainService(IRepository<Grade, Guid> gradesRepository)
        {
            _gradesRepository = gradesRepository;
        }

        public async Task Delete(Guid id)
        {
            await _gradesRepository.DeleteAsync(id);
        }

        public IQueryable<Grade> GetAll()
        {
            return _gradesRepository.GetAllIncluding(x => x.OrganizationLevel, x => x.EducationGrade, x => x.JobTitles);
        }

        public async Task<Grade> GetbyId(Guid id)
        {
            var grade = await _gradesRepository.GetAsync(id);
            if(grade != null)
            {
                await _gradesRepository.EnsurePropertyLoadedAsync(grade, x => x.OrganizationLevel);
                await _gradesRepository.EnsurePropertyLoadedAsync(grade, x => x.EducationGrade);
                await _gradesRepository.EnsureCollectionLoadedAsync(grade, x => x.JobTitles);
            }
            return grade;
        }

        public async Task<Grade> Insert(Grade grade)
        {
            return await _gradesRepository.InsertAsync(grade);
        }

        public async Task<Grade> Update(Grade grade)
        {
            return await _gradesRepository.UpdateAsync(grade);
        }
    }
}
