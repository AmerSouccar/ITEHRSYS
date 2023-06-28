using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Service
{
    public class KinshipTypeAppService : HRSystemAppServiceBase, IKinshipTypeAppService
    {
        private readonly IKinshipTypeDomainService _kinshipTypedomainService;

        public KinshipTypeAppService(IKinshipTypeDomainService kinshipTypedomainService)
        {
            _kinshipTypedomainService = kinshipTypedomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
          await _kinshipTypedomainService.DeleteAsync(id);
        }

        public async Task<List<KinshipTypeDto>> GetAllAsync()
        {
           return ObjectMapper.Map<List<KinshipTypeDto>>(await _kinshipTypedomainService.GetAllAsync());
        }

        public async Task<KinshipTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.GetbyId(id));
        }

        public async Task<KinshipTypeDto> InsertAsync(KinshipTypeDto kinshipType)
        {
           return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.InsertAsync(ObjectMapper.Map<KinshipType>(kinshipType)));
        }

        public async Task<KinshipTypeDto> UpdateAsync(KinshipTypeDto kinshipType)
        {
            return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.UpdateAsync(ObjectMapper.Map<KinshipType>(kinshipType)));

        }
    }
}
