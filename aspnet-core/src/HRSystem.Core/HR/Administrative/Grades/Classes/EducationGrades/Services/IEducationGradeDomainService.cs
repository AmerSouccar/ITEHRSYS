using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.EducationGrades.Services
{
    public interface IEducationGradeDomainService : IDomainService
    {
        public IQueryable<EducationGrade>GetAll();
        public Task<EducationGrade> GetbyId(Guid id);
        public Task<EducationGrade> Insert(EducationGrade educationGrade);
        public Task<EducationGrade> Update(EducationGrade educationGrade);
        public Task Delete(Guid id);
    }
}
