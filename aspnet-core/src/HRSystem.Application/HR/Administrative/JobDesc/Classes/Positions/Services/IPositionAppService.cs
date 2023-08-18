using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Services
{
    public interface IPositionAppService :IApplicationService
    {
        public PagedResultDto<ReadPositionDto> GetAll(PagedGeneralResultRequestDto input);
        public PagedResultDto<ReadPositionDto> GetAllEmptyPositions(PagedGeneralResultRequestDto input);
        public Task<ReadPositionDto> GetbyId(Guid id);
        public Task<UpdatePositionDto> GetForEdit(Guid id);
        public Task<InsertPositionDto> Insert(InsertPositionDto position);
        public Task<UpdatePositionDto> Update(UpdatePositionDto position);
        public Task Delete(Guid id);
    }
}
