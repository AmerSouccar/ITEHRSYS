using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;
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

        public async Task<List<ReadCustodieDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadCustodieDto>>(await _custodieDomainService.GetAll());
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
