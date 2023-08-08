using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Services
{
    public class ConvictionAppService : HRSystemAppServiceBase, IConvictionAppService
    {
        private readonly IConvictionDomainService _convictionDomainService;

        public ConvictionAppService(IConvictionDomainService convictionDomainService)
        {
            _convictionDomainService = convictionDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _convictionDomainService.Delete(id);
        }

        public PagedResultDto<ReadConvictionDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var convictions = _convictionDomainService.GetAll();
            int total = convictions.Count();
            convictions = convictions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadConvictionDto>>(convictions.ToList());
            return new PagedResultDto<ReadConvictionDto>(total, list);
        }

        public async Task<ReadConvictionDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadConvictionDto>(await _convictionDomainService.GetbyId(id));
        }

        public async Task<InsertConvictionDto> Insert(InsertConvictionDto conviction)
        {
            return ObjectMapper.Map<InsertConvictionDto>(await _convictionDomainService.Insert(ObjectMapper.Map<Conviction>(conviction)));
        }

        public async Task<UpdateConvictionDto> Update(UpdateConvictionDto conviction)
        {
            return ObjectMapper.Map<UpdateConvictionDto>(await _convictionDomainService.Update(ObjectMapper.Map<Conviction>(conviction)));

        }
    }
}
