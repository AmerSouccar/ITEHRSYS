using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Educations.Services
{
    public interface IEducationAppService : IApplicationService
    {
        public Task<List<ReadEducationDto>> GetAll();
        public Task<ReadEducationDto> GetbyId(Guid id);
        public Task<InsertEducationDto> Insert(InsertEducationDto education);
        public Task<UpdateEducationDto> Update(UpdateEducationDto education);
        public Task Delete(Guid id);
    }
}
