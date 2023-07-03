using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Dependents.Services
{
    public interface IDependentAppService :IApplicationService
    {
        public Task<List<ReadDependentDto>> GetAll();
        public Task<ReadDependentDto> GetbyId(Guid id);
        public Task<InsertDependentDto> Insert(InsertDependentDto dependent);
        public Task<UpdateDependentDto> Update(UpdateDependentDto dependent);
        public Task Delete(Guid id);
    }
}
