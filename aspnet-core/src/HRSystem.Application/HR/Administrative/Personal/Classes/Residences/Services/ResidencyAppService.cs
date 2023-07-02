using HRSystem.HR.Administrative.Personal.Classes.Residences.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Residences.Services
{
    public class ResidencyAppService : HRSystemAppServiceBase, IResidencyAppService
    {
        private IResidencyDomainService _residencyDomainService;

        public ResidencyAppService(IResidencyDomainService residencyDomainService)
        {
            _residencyDomainService = residencyDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _residencyDomainService.Delete(id);
        }

        public async Task<List<ReadResidencyDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadResidencyDto>>(await _residencyDomainService.GetAll());
        }

        public async Task<ReadResidencyDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadResidencyDto>(await _residencyDomainService.GetbyId(id));
        }

        public async Task<InsertResidencyDto> Insert(InsertResidencyDto residency)
        {
            return ObjectMapper.Map<InsertResidencyDto>(await _residencyDomainService.Insert(ObjectMapper.Map<Residency>(residency)));
        }

        public async Task<UpdateResidencyDto> Update(UpdateResidencyDto residency)
        {
            return ObjectMapper.Map<UpdateResidencyDto>(await _residencyDomainService.Update(ObjectMapper.Map<Residency>(residency)));

        }
    }
}
