using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Services
{
    public interface ICustodieAppService : IApplicationService
    {
        public Task<List<ReadCustodieDto>> GetAll();
        public Task<ReadCustodieDto> GetbyId(Guid id);
        public Task<InsertCustodieDto> Insert(InsertCustodieDto custodie);
        public Task<UpdateCustodieDto> Update(UpdateCustodieDto custodie);
        public Task Delete(Guid id);
    }
}
