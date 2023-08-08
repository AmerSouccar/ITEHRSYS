using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Services
{
    public class CustodieAppService : HRSystemAppServiceBase, ICustodieAppService
    {
        private readonly ICustodieDomainService _custodieDomainService;

        public CustodieAppService(ICustodieDomainService custodieDomainService)
        {
            _custodieDomainService = custodieDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _custodieDomainService.Delete(id);
        }

        public PagedResultDto<ReadCustodieDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var custodies = _custodieDomainService.GetAll();
            int total = custodies.Count();
            custodies = custodies.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadCustodieDto>>(custodies.ToList());
            return new PagedResultDto<ReadCustodieDto>(total, list);
        }

        public async Task<ReadCustodieDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadCustodieDto>(await _custodieDomainService.GetbyId(id));
        }

        public async Task<InsertCustodieDto> Insert(InsertCustodieDto custodie)
        {
           return ObjectMapper.Map<InsertCustodieDto>(await _custodieDomainService.Insert(ObjectMapper.Map<Custodie>(custodie)));
        }

        public async Task<UpdateCustodieDto> Update(UpdateCustodieDto custodie)
        {
            return ObjectMapper.Map<UpdateCustodieDto>(await _custodieDomainService.Update(ObjectMapper.Map<Custodie>(custodie)));

        }
    }
}
