using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Services
{
    public class SpouseAppService : HRSystemAppServiceBase, ISpouseAppService
    {
        private readonly ISpouseDomainService _spouseDomainService;

        public SpouseAppService(ISpouseDomainService spouseDomainService)
        {
            _spouseDomainService = spouseDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _spouseDomainService.Delete(id);
        }

        public async Task<List<ReadSpouseDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadSpouseDto>>(await _spouseDomainService.GetAll());
        }

        public async Task<ReadSpouseDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadSpouseDto>(await _spouseDomainService.GetbyId(id));
        }

        public async Task<InsertSpouseDto> Insert(InsertSpouseDto spouse)
        {
            return ObjectMapper.Map<InsertSpouseDto>(await _spouseDomainService.Insert(ObjectMapper.Map<Spouse>(spouse)));
        }

        public async Task<UpdateSpouseDto> Update(UpdateSpouseDto spouse)
        {
            return ObjectMapper.Map<UpdateSpouseDto>(await _spouseDomainService.Update(ObjectMapper.Map<Spouse>(spouse)));
        }
    }
}
