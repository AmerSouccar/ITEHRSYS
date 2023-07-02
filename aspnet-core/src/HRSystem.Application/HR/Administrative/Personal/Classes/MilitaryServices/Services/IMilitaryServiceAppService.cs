using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Services
{
    public interface IMilitaryServiceAppService :IApplicationService
    {
        public Task<List<ReadMilitaryServiceDto>> GetAll();
        public Task<ReadMilitaryServiceDto> GetbyId(Guid id);
        public Task<InsertMilitaryServiceDto> Insert(InsertMilitaryServiceDto militaryService);
        public Task<UpdateMilitaryServiceDto> Update(UpdateMilitaryServiceDto militaryService);
        public Task Delete(Guid id);
    }
}
