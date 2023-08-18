using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Indexes.PositionWorkTypes.Services
{
    public class PositionWorkTypeAppService : HRSystemAppServiceBase, IPositionWorkTypeAppService
    {
        private readonly IPositionWorkTypeDomainService _positionWorkTypeDomainService;

        public PositionWorkTypeAppService(IPositionWorkTypeDomainService positionWorkTypeDomainService)
        {
            _positionWorkTypeDomainService = positionWorkTypeDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _positionWorkTypeDomainService.DeleteAsync(id);
        }

        public PagedResultDto<ReadPositionWorkTypeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var positionWorkTypes = _positionWorkTypeDomainService.GetAll();
            int total = positionWorkTypes.Count();
            positionWorkTypes = positionWorkTypes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadPositionWorkTypeDto>>(positionWorkTypes.ToList());
            return new PagedResultDto<ReadPositionWorkTypeDto>(total, list);
        }

        public async Task<ReadPositionWorkTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadPositionWorkTypeDto>(await _positionWorkTypeDomainService.GetbyId(id));
        }

        public async Task<UpdatePositionWorkTypeDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdatePositionWorkTypeDto>(await _positionWorkTypeDomainService.GetbyId(id));
        }

        public async Task<InsertPositionWorkTypeDto> InsertAsync(InsertPositionWorkTypeDto positionWorkType)
        {
            return ObjectMapper.Map<InsertPositionWorkTypeDto>(await _positionWorkTypeDomainService.InsertAsync(ObjectMapper.Map<PositionWorkType>(positionWorkType)));
        }

        public async Task<UpdatePositionWorkTypeDto> UpdateAsync(UpdatePositionWorkTypeDto positionWorkType)
        {
            return ObjectMapper.Map<UpdatePositionWorkTypeDto>(await _positionWorkTypeDomainService.UpdateAsync(ObjectMapper.Map<PositionWorkType>(positionWorkType)));

        }
    }
}
