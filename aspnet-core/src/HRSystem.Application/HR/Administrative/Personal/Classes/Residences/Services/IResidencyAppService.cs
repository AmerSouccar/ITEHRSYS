using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Services
{
    public interface IResidencyAppService : IApplicationService
    {
        public Task<List<ReadResidencyDto>> GetAll();
        public Task<ReadResidencyDto> GetbyId(Guid id);
        public Task<InsertResidencyDto> Insert(InsertResidencyDto residency);
        public Task<UpdateResidencyDto> Update(UpdateResidencyDto residency);
        public Task Delete(Guid id);
    }
}
