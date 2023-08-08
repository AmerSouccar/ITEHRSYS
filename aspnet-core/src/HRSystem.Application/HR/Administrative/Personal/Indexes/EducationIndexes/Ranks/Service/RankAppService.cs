using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.Ranks.Service
{
    public class RankAppService : HRSystemAppServiceBase, IRankAppService
    {
        private readonly IRankDomainService _rankpeDomainService;

        public RankAppService(IRankDomainService rankpeDomainService)
        {
            _rankpeDomainService = rankpeDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _rankpeDomainService.DeleteAsync(id);
        }

        public PagedResultDto<RankDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var ranks = _rankpeDomainService.GetAll();
            int total = ranks.Count();
            ranks = ranks.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<RankDto>>(ranks.ToList());
            return new PagedResultDto<RankDto>(total, list);
        }

        public async Task<RankDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<RankDto>(await _rankpeDomainService.GetbyId(id));
        }

        public async Task<RankDto> InsertAsync(RankDto rank)
        {
           return ObjectMapper.Map<RankDto>(await _rankpeDomainService.InsertAsync(ObjectMapper.Map<Rank>(rank)));
        }

        public async Task<RankDto> UpdateAsync(RankDto rank)
        {
            return ObjectMapper.Map<RankDto>(await _rankpeDomainService.UpdateAsync(ObjectMapper.Map<Rank>(rank)));

        }
    }
}
