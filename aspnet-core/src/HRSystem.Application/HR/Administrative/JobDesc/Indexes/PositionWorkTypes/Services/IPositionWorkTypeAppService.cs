using Abp.Application.Services;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Services
{
    public interface IPositionWorkTypeAppService :IApplicationService
    {
        Task<List<ReadPositionWorkTypeDto>> GetAllAsync();
        Task<ReadPositionWorkTypeDto> GetbyId(Guid id);
        Task<InsertPositionWorkTypeDto> InsertAsync(InsertPositionWorkTypeDto positionWorkType);
        Task<UpdatePositionWorkTypeDto> UpdateAsync(UpdatePositionWorkTypeDto positionWorkType);
        Task DeleteAsync(Guid id);
    }
}
