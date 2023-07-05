using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
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

        public async Task<List<ReadPositionDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadPositionDto>>(await _positionDomainService.GetAll());
        }

        public async Task<ReadPositionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadPositionDto>(await _positionDomainService.GetbyId(id));
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
