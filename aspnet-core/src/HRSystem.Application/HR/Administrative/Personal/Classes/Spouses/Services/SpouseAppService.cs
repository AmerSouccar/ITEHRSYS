using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadSpouseDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var spouses = _spouseDomainService.GetAll();
            int total = spouses.Count();
            spouses = spouses.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadSpouseDto>>(spouses.ToList());
            return new PagedResultDto<ReadSpouseDto>(total, list);
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
