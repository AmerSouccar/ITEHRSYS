using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
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

        public async Task<List<ReadConvictionDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadConvictionDto>>(await _convictionDomainService.GetAll());
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
