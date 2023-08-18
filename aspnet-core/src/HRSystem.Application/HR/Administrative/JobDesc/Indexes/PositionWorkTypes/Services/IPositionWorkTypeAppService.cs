using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Services
{
    public interface IPositionWorkTypeAppService :IApplicationService
    {
        PagedResultDto<ReadPositionWorkTypeDto> GetAll(PagedGeneralResultRequestDto input);
        Task<ReadPositionWorkTypeDto> GetbyId(Guid id);
        Task<UpdatePositionWorkTypeDto> GetForEdit(Guid id);
        Task<InsertPositionWorkTypeDto> InsertAsync(InsertPositionWorkTypeDto positionWorkType);
        Task<UpdatePositionWorkTypeDto> UpdateAsync(UpdatePositionWorkTypeDto positionWorkType);
        Task DeleteAsync(Guid id);
    }
}
