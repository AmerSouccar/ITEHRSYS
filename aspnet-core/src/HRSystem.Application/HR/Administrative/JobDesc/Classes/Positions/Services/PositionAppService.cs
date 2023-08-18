using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.JobDescriptions.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.JobDesc.Classes.Positions.Services
{
    public class PositionAppService : HRSystemAppServiceBase, IPositionAppService
    {
        private readonly IPositionDomainService _positionDomainService;

        public PositionAppService(IPositionDomainService positionDomainService)
        {
            _positionDomainService = positionDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _positionDomainService.Delete(id);
        }

        public PagedResultDto<ReadPositionDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var positions = _positionDomainService.GetAll();
            int total = positions.Count();
            positions = positions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadPositionDto>>(positions.ToList());
            return new PagedResultDto<ReadPositionDto>(total, list);
        }

        public PagedResultDto<ReadPositionDto> GetAllEmptyPositions(PagedGeneralResultRequestDto input)
        {
            var positions = _positionDomainService.GetAllEmptyPositions();
            int total = positions.Count();
            positions = positions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadPositionDto>>(positions.ToList());
            return new PagedResultDto<ReadPositionDto>(total, list);
        }

        public async Task<ReadPositionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadPositionDto>(await _positionDomainService.GetbyId(id));
        }

        public async Task<UpdatePositionDto> GetForEdit(Guid id)
        {
            return ObjectMapper.Map<UpdatePositionDto>(await _positionDomainService.GetbyId(id));
        }

        public async Task<InsertPositionDto> Insert(InsertPositionDto position)
        {
            return ObjectMapper.Map<InsertPositionDto>(await _positionDomainService.Insert(ObjectMapper.Map<Position>(position)));
        }

        public async Task<UpdatePositionDto> Update(UpdatePositionDto position)
        {
            return ObjectMapper.Map<UpdatePositionDto>(await _positionDomainService.Update(ObjectMapper.Map<Position>(position)));

        }
    }
}
