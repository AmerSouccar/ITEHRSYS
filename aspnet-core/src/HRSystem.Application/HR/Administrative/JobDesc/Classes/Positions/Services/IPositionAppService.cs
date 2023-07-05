using Abp.Application.Services;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Services
{
    public interface IPositionAppService :IApplicationService
    {
        public Task<List<ReadPositionDto>> GetAll();
        public Task<ReadPositionDto> GetbyId(Guid id);
        public Task<InsertPositionDto> Insert(InsertPositionDto position);
        public Task<UpdatePositionDto> Update(UpdatePositionDto position);
        public Task Delete(Guid id);
    }
}
